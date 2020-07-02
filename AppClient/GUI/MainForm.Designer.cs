namespace GUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.gameLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.signLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.chatLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.accountLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.minimizeLabel);
            this.headerPanel.Controls.Add(this.closeLabel);
            this.headerPanel.Location = new System.Drawing.Point(0, -2);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(972, 88);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client Gaming";
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("minimizeLabel.Image")));
            this.minimizeLabel.Location = new System.Drawing.Point(879, 3);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(36, 31);
            this.minimizeLabel.TabIndex = 2;
            this.minimizeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minimizeLabel_MouseDown);
            this.minimizeLabel.MouseEnter += new System.EventHandler(this.minimizeLabel_MouseEnter);
            this.minimizeLabel.MouseLeave += new System.EventHandler(this.minimizeLabel_MouseLeave);
            // 
            // closeLabel
            // 
            this.closeLabel.Image = ((System.Drawing.Image)(resources.GetObject("closeLabel.Image")));
            this.closeLabel.Location = new System.Drawing.Point(931, 3);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(36, 31);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseDown);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidePanel.Controls.Add(this.gameLabel);
            this.sidePanel.Controls.Add(this.exitLabel);
            this.sidePanel.Controls.Add(this.signLabel);
            this.sidePanel.Controls.Add(this.helpLabel);
            this.sidePanel.Controls.Add(this.chatLabel);
            this.sidePanel.Controls.Add(this.foodLabel);
            this.sidePanel.Controls.Add(this.accountLabel);
            this.sidePanel.Location = new System.Drawing.Point(0, 83);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(130, 534);
            this.sidePanel.TabIndex = 2;
            // 
            // gameLabel
            // 
            this.gameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameLabel.Image = ((System.Drawing.Image)(resources.GetObject("gameLabel.Image")));
            this.gameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gameLabel.Location = new System.Drawing.Point(1, 131);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gameLabel.Size = new System.Drawing.Size(130, 42);
            this.gameLabel.TabIndex = 8;
            this.gameLabel.Text = "    Games";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameLabel_MouseDown);
            this.gameLabel.MouseEnter += new System.EventHandler(this.gameLabel_MouseEnter);
            this.gameLabel.MouseLeave += new System.EventHandler(this.gameLabel_MouseLeave);
            // 
            // exitLabel
            // 
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitLabel.Image = ((System.Drawing.Image)(resources.GetObject("exitLabel.Image")));
            this.exitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitLabel.Location = new System.Drawing.Point(1, 404);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitLabel.Size = new System.Drawing.Size(130, 46);
            this.exitLabel.TabIndex = 7;
            this.exitLabel.Text = "     Đăng xuất";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitLabel_MouseDown);
            this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            // 
            // signLabel
            // 
            this.signLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signLabel.Location = new System.Drawing.Point(0, 77);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(128, 10);
            this.signLabel.TabIndex = 2;
            // 
            // helpLabel
            // 
            this.helpLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpLabel.Image = ((System.Drawing.Image)(resources.GetObject("helpLabel.Image")));
            this.helpLabel.Location = new System.Drawing.Point(-1, 463);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpLabel.Size = new System.Drawing.Size(130, 60);
            this.helpLabel.TabIndex = 6;
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpLabel.MouseEnter += new System.EventHandler(this.helpLabel_MouseEnter);
            this.helpLabel.MouseLeave += new System.EventHandler(this.helpLabel_MouseLeave);
            // 
            // chatLabel
            // 
            this.chatLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chatLabel.Image = ((System.Drawing.Image)(resources.GetObject("chatLabel.Image")));
            this.chatLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chatLabel.Location = new System.Drawing.Point(1, 310);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chatLabel.Size = new System.Drawing.Size(130, 42);
            this.chatLabel.TabIndex = 5;
            this.chatLabel.Text = "    Tin nhắn";
            this.chatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chatLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chatLabel_MouseDown);
            this.chatLabel.MouseEnter += new System.EventHandler(this.chatLabel_MouseEnter);
            this.chatLabel.MouseLeave += new System.EventHandler(this.chatLabel_MouseLeave);
            // 
            // foodLabel
            // 
            this.foodLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.foodLabel.Image = ((System.Drawing.Image)(resources.GetObject("foodLabel.Image")));
            this.foodLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodLabel.Location = new System.Drawing.Point(1, 222);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foodLabel.Size = new System.Drawing.Size(130, 38);
            this.foodLabel.TabIndex = 3;
            this.foodLabel.Text = "  Đồ ăn";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foodLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.foodLabel_MouseDown);
            this.foodLabel.MouseEnter += new System.EventHandler(this.foodLabel_MouseEnter);
            this.foodLabel.MouseLeave += new System.EventHandler(this.foodLabel_MouseLeave);
            // 
            // accountLabel
            // 
            this.accountLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountLabel.Image = ((System.Drawing.Image)(resources.GetObject("accountLabel.Image")));
            this.accountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountLabel.Location = new System.Drawing.Point(0, 40);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountLabel.Size = new System.Drawing.Size(130, 37);
            this.accountLabel.TabIndex = 2;
            this.accountLabel.Text = "      Tài khoản";
            this.accountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.accountLabel_MouseDown);
            this.accountLabel.MouseEnter += new System.EventHandler(this.accountLabel_MouseEnter);
            this.accountLabel.MouseLeave += new System.EventHandler(this.accountLabel_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 616);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label chatLabel;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label accountLabel;
    }
}