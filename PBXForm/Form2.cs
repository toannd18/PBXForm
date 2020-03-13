using PBXForm.Service;
using System;
using System.Windows.Forms;

namespace PBXForm
{
    public partial class Form2 : Form
    {
        public SystemSetting systemSetting;

        public Form2()
        {
            InitializeComponent();
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            systemSetting = new SystemSetting();
            await systemSetting.Load_Account();
            await systemSetting.Load_Devices();
            Account acc = systemSetting._account;
            int idMicro = systemSetting._microInfos.FindIndex(m => m.DeviceID == acc.DeviceMicro);
            int idSpeaker = systemSetting._speakerInfos.FindIndex(m => m.DeviceID == acc.DeviceSpeaker);

            cbMicroPhone.DataSource = systemSetting._microInfos;
            cbMicroPhone.DisplayMember = "ProductName";

            cbMicroPhone.SelectedIndex = idMicro > 0 ? idMicro : 0;

            cbSpeaker.DataSource = systemSetting._speakerInfos;
            cbSpeaker.DisplayMember = "ProductName";

            cbSpeaker.SelectedIndex = idSpeaker > 0 ? idSpeaker : 0;
            txtDName.Text = acc.DisplayName;
            txtDomain.Text = acc.DomainServerHost;
            txtDPort.Text = acc.DomainServerPort;
            txtPwork.Text = acc.RegisterPassword;
            txtUName.Text = acc.UserName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }
    }
}