namespace PBXForm
{
    partial class frm_main
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
            System.Windows.Forms.PictureBox btn_close;
            this.panel_tool = new System.Windows.Forms.Panel();
            this.lab_title = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_call = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.btnHangUp = new System.Windows.Forms.Button();
            this.lsLog = new System.Windows.Forms.ListBox();
            btn_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(btn_close)).BeginInit();
            this.panel_tool.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_close.Image = global::PBXForm.Properties.Resources.icons8_delete_30;
            btn_close.Location = new System.Drawing.Point(1117, 0);
            btn_close.Margin = new System.Windows.Forms.Padding(0);
            btn_close.Name = "btn_close";
            btn_close.Padding = new System.Windows.Forms.Padding(2);
            btn_close.Size = new System.Drawing.Size(40, 40);
            btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            btn_close.TabIndex = 1;
            btn_close.TabStop = false;
            btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_tool
            // 
            this.panel_tool.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_tool.Controls.Add(btn_close);
            this.panel_tool.Controls.Add(this.lab_title);
            this.panel_tool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tool.Location = new System.Drawing.Point(0, 0);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(1157, 40);
            this.panel_tool.TabIndex = 0;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_title.Location = new System.Drawing.Point(3, 6);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(94, 31);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = "Mirats";
            this.lab_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel_menu.Controls.Add(this.btn_set);
            this.panel_menu.Controls.Add(this.btn_call);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 40);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(100, 692);
            this.panel_menu.TabIndex = 1;
            // 
            // btn_set
            // 
            this.btn_set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_set.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_set.FlatAppearance.BorderSize = 0;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_set.Image = global::PBXForm.Properties.Resources.icons8_number_pad_32;
            this.btn_set.Location = new System.Drawing.Point(0, 88);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(100, 88);
            this.btn_set.TabIndex = 1;
            this.btn_set.Text = "Setting";
            this.btn_set.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_call
            // 
            this.btn_call.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_call.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_call.FlatAppearance.BorderSize = 0;
            this.btn_call.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_call.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_call.Image = global::PBXForm.Properties.Resources.icons8_number_pad_32;
            this.btn_call.Location = new System.Drawing.Point(0, 0);
            this.btn_call.Name = "btn_call";
            this.btn_call.Size = new System.Drawing.Size(100, 88);
            this.btn_call.TabIndex = 0;
            this.btn_call.Text = "Menu";
            this.btn_call.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_call.UseVisualStyleBackColor = true;
            this.btn_call.Click += new System.EventHandler(this.btn_call_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Controls.Add(this.lsLog);
            this.flowLayoutPanel1.Controls.Add(this.btnPickUp);
            this.flowLayoutPanel1.Controls.Add(this.btnHangUp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1057, 692);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnPickUp
            // 
            this.btnPickUp.BackColor = System.Drawing.Color.Lime;
            this.btnPickUp.FlatAppearance.BorderSize = 0;
            this.btnPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickUp.Location = new System.Drawing.Point(13, 115);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(129, 95);
            this.btnPickUp.TabIndex = 0;
            this.btnPickUp.Text = "Pick Up";
            this.btnPickUp.UseVisualStyleBackColor = false;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // btnHangUp
            // 
            this.btnHangUp.BackColor = System.Drawing.Color.Sienna;
            this.btnHangUp.FlatAppearance.BorderSize = 0;
            this.btnHangUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangUp.Location = new System.Drawing.Point(148, 115);
            this.btnHangUp.Name = "btnHangUp";
            this.btnHangUp.Size = new System.Drawing.Size(129, 95);
            this.btnHangUp.TabIndex = 1;
            this.btnHangUp.Text = "Hang Up";
            this.btnHangUp.UseVisualStyleBackColor = false;
            this.btnHangUp.Click += new System.EventHandler(this.btnHangUp_Click);
            // 
            // lsLog
            // 
            this.lsLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsLog.FormattingEnabled = true;
            this.lsLog.Location = new System.Drawing.Point(13, 13);
            this.lsLog.Name = "lsLog";
            this.lsLog.Size = new System.Drawing.Size(906, 95);
            this.lsLog.TabIndex = 2;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1157, 732);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_tool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(btn_close)).EndInit();
            this.panel_tool.ResumeLayout(false);
            this.panel_tool.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_tool;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_call;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.Button btnHangUp;
        private System.Windows.Forms.ListBox lsLog;
    }
}

