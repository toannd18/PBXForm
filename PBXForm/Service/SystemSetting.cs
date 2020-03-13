using Ozeki.Media;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;

namespace PBXForm.Service
{
    public class SystemSetting
    {
        public List<AudioDeviceInfo> _microInfos;
        public List<AudioDeviceInfo> _speakerInfos;
        public Account _account;
        public string path = System.IO.Directory.GetCurrentDirectory();

        public SystemSetting()
        {
            _account = new Account();
        }

        public async Task Load_Devices()
        {
            await Task.Run(() =>
            {
                _microInfos = Microphone.GetDevices();
                _speakerInfos = Speaker.GetDevices();
            });
        }

        public async Task Load_Account()
        {
            await Task.Run(() =>
            {
                path = Path.Combine(path, "appSetting.xml");
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(path);
                XmlElement root = xmldoc.DocumentElement;
                _account.DisplayName = root.SelectSingleNode("account").SelectSingleNode("displayname").InnerText;
                _account.UserName = root.SelectSingleNode("account")["username"].InnerText;
                _account.RegisterPassword = root.SelectSingleNode("account")["passwork"].InnerText;
                _account.DomainServerHost = root.SelectSingleNode("account")["domain"].InnerText;
                _account.DomainServerPort = root.SelectSingleNode("account")["port"].InnerText;
                _account.DeviceMicro = root.SelectSingleNode("device")["microphone"].InnerText;
                _account.DeviceSpeaker = root.SelectSingleNode("device")["speaker"].InnerText;
            });
        }

        public async Task Edit_Setting(Account account)
        {
            await Task.Run(() =>
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(path);
                var root = xmldoc.DocumentElement;
                root.SelectSingleNode("account")["displayname"].InnerText = account.DisplayName;
                root.SelectSingleNode("account")["username"].InnerText = account.UserName;
                root.SelectSingleNode("account")["passwork"].InnerText = account.RegisterPassword;
                root.SelectSingleNode("account")["domain"].InnerText = account.DomainServerHost;
                root.SelectSingleNode("account")["port"].InnerText = account.DomainServerPort;
                root.SelectSingleNode("device")["microphone"].InnerText = account.DeviceMicro;
                root.SelectSingleNode("device")["speaker"].InnerText = account.DeviceMicro;
                xmldoc.Save(path);
            }
            );
        }
    }

    public class Account
    {
        public string DisplayName { get; set; }

        public string UserName { get; set; }

        public string RegisterPassword { get; set; }

        public string DomainServerHost { get; set; }

        public string DomainServerPort { get; set; }
        public string DeviceMicro { get; set; }
        public string DeviceSpeaker { get; set; }
    }
}