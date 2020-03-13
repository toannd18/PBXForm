using Ozeki.Media;
using PBXForm.Service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBXForm
{
    public partial class frm_main : Form
    {
        private Softphone _softphone;

        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_call_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var dialNumber = form.lb_Dial.Text.Trim();
                _softphone.Pick_up(dialNumber);
            }
        }

        private async void btn_set_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog(this);
            if (form.DialogResult == DialogResult.OK)
            {
                Account account = new Account();
                account.DisplayName = form.txtDName.Text;
                account.UserName = form.txtUName.Text;
                account.RegisterPassword = form.txtPwork.Text;
                account.DomainServerHost = form.txtDomain.Text;
                account.DomainServerPort = form.txtDPort.Text;
                account.DeviceSpeaker = ((AudioDeviceInfo)form.cbSpeaker.SelectedItem).DeviceID;
                account.DeviceMicro = ((AudioDeviceInfo)form.cbMicroPhone.SelectedItem).DeviceID;
                await form.systemSetting.Edit_Setting(account);
                form.Close();
            };
            if (form.DialogResult == DialogResult.Cancel)
            {
                form.Close();
            }
        }

        private async void frm_main_Load(object sender, EventArgs e)
        {
            _softphone = new Softphone();
            _softphone.InitializeSoftPhone();
            await InvokeGUIThread(() => { lsLog.DataSource = _softphone._message; });
        }

        private async void btnPickUp_Click(object sender, EventArgs e)
        {
            _softphone.Pick_up("");

            await InvokeGUIThread(()=> { lsLog.DataSource = _softphone._message; });
        }

        private async void btnHangUp_Click(object sender, EventArgs e)
        {
            _softphone.Hang_up();
            await InvokeGUIThread(() => { lsLog.DataSource = _softphone._message; });
        }
        private async Task InvokeGUIThread(Action action)
        {
            await Task.Run(action);
        }
    }
}