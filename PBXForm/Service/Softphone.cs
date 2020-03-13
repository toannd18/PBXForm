using Ozeki.Media;
using Ozeki.VoIP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PBXForm.Service
{
    public class Softphone
    {
        private ISoftPhone _softPhone;
        private IPhoneLine _phoneLine;
        private RegState _phoneLineInformation;
        private IPhoneCall _call;
        private Microphone _microphone = Microphone.GetDefaultDevice();
        private Speaker _speaker = Speaker.GetDefaultDevice();
        private MediaConnector _connector = new MediaConnector();
        private MediaConnector mediaConnector = new MediaConnector();
        private PhoneCallAudioSender _mediaSender = new PhoneCallAudioSender();
        private PhoneCallAudioReceiver _mediaReceiver = new PhoneCallAudioReceiver();
        private MP3StreamPlayback mp3Player;

        private bool _inComingCall;

        private string _reDialNumber;

        //private bool _localHeld;
        private string _registerName;

        public List<string> _message;

        public void InitializeSoftPhone()
        {
            try
            {
                var userAgent = "MyFirstSoftPhone-3-example";
                _message = new List<string>();
                _softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(), 5700, 5750, userAgent);
                _message.Add("Softphone created!");
                //InvokeGUIThread(() => { lb_Log.Items.Add("Softphone created!"); });

                _softPhone.IncomingCall += softPhone_inComingCall;

                SIPAccount sa = new SIPAccount(true, "2001", "2001", "2001", "2001", "172.16.1.17");
                _message.Add("SIP account created!");
                //InvokeGUIThread(() => { lb_Log.Items.Add("SIP account created!"); });

                _phoneLine = _softPhone.CreatePhoneLine(sa);
                _phoneLine.RegistrationStateChanged += phoneLine_PhoneLineInformation;
                _message.Add("Phoneline created.");
                //InvokeGUIThread(() => { lb_Log.Items.Add("Phoneline created."); });
                _softPhone.RegisterPhoneLine(_phoneLine);

                _registerName = sa.RegisterName;

                _inComingCall = false;
                _reDialNumber = string.Empty;
                //_localHeld = false;

                ConnectMedia();
            }
            catch (Exception ex)
            {
                _message.Add(ex.ToString());
            }
        }

        private void WireUpCallEvents()
        {
            _call.CallStateChanged += (call_CallStateChanged);
        }

        private void WireDownCallEvents()
        {
            _call.CallStateChanged -= (call_CallStateChanged);
        }

        private void softPhone_inComingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            _message = new List<string>();
            _message.Add(e.Item.DialInfo.ToString());

            _reDialNumber = e.Item.DialInfo.Dialed;
            StartMP3Ring("Ringing.mp3");
            _call = e.Item;
            WireUpCallEvents();
            _inComingCall = true;
        }

        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            _message = new List<string>();
            _message.Add(e.State.ToString());
            StopMp3Ring();
            if (e.State == CallState.Answered)
            {
                StartDevices();

                _mediaReceiver.AttachToCall(_call);
                _mediaSender.AttachToCall(_call);

                //InvokeGUIThread(() => { lb_Log.Items.Add("Call started."); });
            }

            if (e.State == CallState.InCall)
            {
                //btn_Hold.Enabled = true;
                //btn_Hold.Text = "Hold";
                StartDevices();
            }

            if (e.State.IsRinging())
            {
                StartMP3Ring("Ringing.mp3");
            }
            if (e.State == CallState.Busy)
            {
                StartMP3Ring("Busy.mp3");
            }

            if (e.State.IsCallEnded())
            {
                //_localHeld = false;

                StopDevices();

                _mediaReceiver.Detach();
                _mediaSender.Detach();

                WireDownCallEvents();

                _call = null;

                //InvokeGUIThread(() => { lb_Log.Items.Add("Call ended."); tb_Display.Text = string.Empty; });
            }

            if (e.State == CallState.LocalHeld)
            {
                StopDevices();
            }
        }

        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {
            _phoneLineInformation = e.State;
     
            if (_phoneLineInformation == RegState.RegistrationSucceeded)
            {
                _message.Add("Registration succeeded - Online");
            }
            else
            {
                _message.Add($"Not registered - Offline: {_phoneLineInformation.ToString()}");
            }
        }

        #region Connect Devices

        private void StartDevices()
        {
            if (_microphone != null)
            {
                _microphone.Start();
                //InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Started."); });
            }

            if (_speaker != null)
            {
                _speaker.Start();
                //InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Started."); });
            }
        }

        private void StopDevices()
        {
            if (_microphone != null)
            {
                _microphone.Stop();
                //InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Stopped."); });
            }

            if (_speaker != null)
            {
                _speaker.Stop();
                //InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Stopped."); });
            }
        }

        private void ConnectMedia()
        {
            if (_microphone != null)
            {
                _connector.Connect(_microphone, _mediaSender);
            }

            if (_speaker != null)
            {
                _connector.Connect(_mediaReceiver, _speaker);
            }
        }

        private void DisconnectMedia()
        {
            if (_microphone != null)
            {
                _connector.Disconnect(_microphone, _mediaSender);
            }

            if (_speaker != null)
            {
                _connector.Disconnect(_mediaReceiver, _speaker);
            }
        }

        private void StartMP3Ring(string fileMp3)
        {
            string _path = Path.Combine(Application.StartupPath, fileMp3);
            mp3Player = new MP3StreamPlayback(_path);
            mediaConnector = new MediaConnector();
            if (mp3Player != null && _speaker != null)
            {
                mediaConnector.Connect(mp3Player, _speaker);
                mp3Player.Start();
                _speaker.Start();
            }
        }

        private void StopMp3Ring()
        {
            if (mp3Player != null && _speaker != null)
            {
                mediaConnector.Disconnect(mp3Player, _speaker);
                mediaConnector.Dispose();
                mp3Player.Dispose();
                _speaker.Stop();
            }
        }

        #endregion Connect Devices

        #region Process Call

        public void Pick_up(string _numberDial)
        {
            if (_inComingCall)
            {
                _inComingCall = false;
                _call.Answer();
                return;
            }
            if (_call != null)
            {
                return;
            }
            if (_phoneLineInformation != RegState.RegistrationSucceeded)
            {
                _message.Add("Registratin Failed! OFFLINE");
                return;
            }

            _call = _softPhone.CreateCallObject(_phoneLine, string.IsNullOrWhiteSpace(_numberDial) ? _reDialNumber : _numberDial);
            WireUpCallEvents();
            _call.Start();
        }

        public void Hang_up()
        {
            if (_call != null)
            {
                if (_inComingCall && _call.CallState == CallState.Ringing)
                {
                    _call.Reject();
                    _message.Add("Call Rejected");
                }
                else
                {
                    _call.HangUp();

                    _message.Add("Call hanged up");
                }
                _inComingCall = false;
                _call = null;
            }
        }

        #endregion Process Call
    }
}