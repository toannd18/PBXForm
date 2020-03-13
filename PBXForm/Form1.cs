using System;
using System.Linq;
using System.Windows.Forms;

namespace PBXForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btn_Pickup.DialogResult = DialogResult.OK;
            this.btn_Hangup.DialogResult = DialogResult.Cancel;
            var buttons = this.Controls.OfType<Button>().ToList();
            foreach (var btn in buttons)
            {
                if (int.TryParse(btn.Text, out int numValue))
                {
                    btn.Click += new EventHandler(btn_Click);
                }
            }
        }

       

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            lb_Dial.Text += btn.Text;
        }
    }
}