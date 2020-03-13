namespace PBXForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpAccount = new System.Windows.Forms.GroupBox();
            this.txtDPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwork = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.lbDisplayName = new System.Windows.Forms.Label();
            this.gpDevice = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbSpeaker = new System.Windows.Forms.ComboBox();
            this.cbMicroPhone = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpAccount.SuspendLayout();
            this.gpDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpAccount
            // 
            this.gpAccount.Controls.Add(this.txtDPort);
            this.gpAccount.Controls.Add(this.label5);
            this.gpAccount.Controls.Add(this.txtDomain);
            this.gpAccount.Controls.Add(this.label4);
            this.gpAccount.Controls.Add(this.txtPwork);
            this.gpAccount.Controls.Add(this.label3);
            this.gpAccount.Controls.Add(this.txtUName);
            this.gpAccount.Controls.Add(this.label1);
            this.gpAccount.Controls.Add(this.txtDName);
            this.gpAccount.Controls.Add(this.lbDisplayName);
            this.gpAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpAccount.Location = new System.Drawing.Point(0, 0);
            this.gpAccount.Name = "gpAccount";
            this.gpAccount.Size = new System.Drawing.Size(426, 233);
            this.gpAccount.TabIndex = 0;
            this.gpAccount.TabStop = false;
            this.gpAccount.Text = "Account";
            // 
            // txtDPort
            // 
            this.txtDPort.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtDPort.Location = new System.Drawing.Point(154, 150);
            this.txtDPort.Name = "txtDPort";
            this.txtDPort.Size = new System.Drawing.Size(183, 20);
            this.txtDPort.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Domain Port";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(154, 124);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(183, 20);
            this.txtDomain.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domain";
            // 
            // txtPwork
            // 
            this.txtPwork.Location = new System.Drawing.Point(154, 98);
            this.txtPwork.Name = "txtPwork";
            this.txtPwork.Size = new System.Drawing.Size(183, 20);
            this.txtPwork.TabIndex = 7;
            this.txtPwork.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passwork";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(154, 71);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(183, 20);
            this.txtUName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(154, 36);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(183, 20);
            this.txtDName.TabIndex = 1;
            // 
            // lbDisplayName
            // 
            this.lbDisplayName.AutoSize = true;
            this.lbDisplayName.Location = new System.Drawing.Point(37, 39);
            this.lbDisplayName.Name = "lbDisplayName";
            this.lbDisplayName.Size = new System.Drawing.Size(72, 13);
            this.lbDisplayName.TabIndex = 0;
            this.lbDisplayName.Text = "Display Name";
            // 
            // gpDevice
            // 
            this.gpDevice.Controls.Add(this.btnCancel);
            this.gpDevice.Controls.Add(this.btnOk);
            this.gpDevice.Controls.Add(this.cbSpeaker);
            this.gpDevice.Controls.Add(this.cbMicroPhone);
            this.gpDevice.Controls.Add(this.label6);
            this.gpDevice.Controls.Add(this.label7);
            this.gpDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpDevice.Location = new System.Drawing.Point(0, 233);
            this.gpDevice.Name = "gpDevice";
            this.gpDevice.Size = new System.Drawing.Size(426, 158);
            this.gpDevice.TabIndex = 1;
            this.gpDevice.TabStop = false;
            this.gpDevice.Text = "Devices";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(262, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(207)))), ((int)(((byte)(46)))));
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(154, 108);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbSpeaker
            // 
            this.cbSpeaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeaker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSpeaker.FormattingEnabled = true;
            this.cbSpeaker.Location = new System.Drawing.Point(154, 67);
            this.cbSpeaker.Name = "cbSpeaker";
            this.cbSpeaker.Size = new System.Drawing.Size(183, 21);
            this.cbSpeaker.TabIndex = 8;
            // 
            // cbMicroPhone
            // 
            this.cbMicroPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMicroPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMicroPhone.FormattingEnabled = true;
            this.cbMicroPhone.Location = new System.Drawing.Point(154, 32);
            this.cbMicroPhone.Name = "cbMicroPhone";
            this.cbMicroPhone.Size = new System.Drawing.Size(183, 21);
            this.cbMicroPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Speaker";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "MicroPhone";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(426, 391);
            this.Controls.Add(this.gpDevice);
            this.Controls.Add(this.gpAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gpAccount.ResumeLayout(false);
            this.gpAccount.PerformLayout();
            this.gpDevice.ResumeLayout(false);
            this.gpDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAccount;
        private System.Windows.Forms.GroupBox gpDevice;
        private System.Windows.Forms.Label lbDisplayName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDName;
        public System.Windows.Forms.TextBox txtDomain;
        public System.Windows.Forms.TextBox txtPwork;
        public System.Windows.Forms.TextBox txtUName;
        public System.Windows.Forms.TextBox txtDPort;
        public System.Windows.Forms.ComboBox cbSpeaker;
        public System.Windows.Forms.ComboBox cbMicroPhone;
    }
}