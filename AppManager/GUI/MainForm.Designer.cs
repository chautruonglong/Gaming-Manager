using System.Drawing;

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
            this.exitLabel = new System.Windows.Forms.Label();
            this.signLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.accountsLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
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
            this.headerPanel.Location = new System.Drawing.Point(0, -1);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(929, 85);
            this.headerPanel.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gaming Manager";
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("minimizeLabel.Image")));
            this.minimizeLabel.Location = new System.Drawing.Point(851, 0);
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
            this.closeLabel.Location = new System.Drawing.Point(893, 0);
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
            this.sidePanel.Controls.Add(this.exitLabel);
            this.sidePanel.Controls.Add(this.signLabel);
            this.sidePanel.Controls.Add(this.helpLabel);
            this.sidePanel.Controls.Add(this.accountsLabel);
            this.sidePanel.Controls.Add(this.foodLabel);
            this.sidePanel.Controls.Add(this.computerLabel);
            this.sidePanel.Location = new System.Drawing.Point(0, 84);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(130, 493);
            this.sidePanel.TabIndex = 1;
            // 
            // exitLabel
            // 
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitLabel.Image = ((System.Drawing.Image)(resources.GetObject("exitLabel.Image")));
            this.exitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitLabel.Location = new System.Drawing.Point(-1, 373);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitLabel.Size = new System.Drawing.Size(130, 46);
            this.exitLabel.TabIndex = 7;
            this.exitLabel.Text = "     Đăng xuất";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
            // 
            // signLabel
            // 
            this.signLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signLabel.Location = new System.Drawing.Point(1, 77);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(128, 10);
            this.signLabel.TabIndex = 2;
            // 
            // helpLabel
            // 
            this.helpLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpLabel.Image = ((System.Drawing.Image)(resources.GetObject("helpLabel.Image")));
            this.helpLabel.Location = new System.Drawing.Point(0, 434);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpLabel.Size = new System.Drawing.Size(130, 60);
            this.helpLabel.TabIndex = 6;
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.helpLabel.MouseEnter += new System.EventHandler(this.helpLabel_MouseEnter);
            this.helpLabel.MouseLeave += new System.EventHandler(this.helpLabel_MouseLeave);
            // 
            // accountsLabel
            // 
            this.accountsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountsLabel.Image = ((System.Drawing.Image)(resources.GetObject("accountsLabel.Image")));
            this.accountsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountsLabel.Location = new System.Drawing.Point(0, 253);
            this.accountsLabel.Name = "accountsLabel";
            this.accountsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountsLabel.Size = new System.Drawing.Size(130, 42);
            this.accountsLabel.TabIndex = 5;
            this.accountsLabel.Text = "    Quản lý";
            this.accountsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountsLabel.Click += new System.EventHandler(this.accountsLabel_Click);
            this.accountsLabel.MouseEnter += new System.EventHandler(this.accountsLabel_MouseEnter);
            this.accountsLabel.MouseLeave += new System.EventHandler(this.accountsLabel_MouseLeave);
            // 
            // foodLabel
            // 
            this.foodLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.foodLabel.Image = ((System.Drawing.Image)(resources.GetObject("foodLabel.Image")));
            this.foodLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.foodLabel.Location = new System.Drawing.Point(-1, 159);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foodLabel.Size = new System.Drawing.Size(130, 38);
            this.foodLabel.TabIndex = 3;
            this.foodLabel.Text = "  Đồ ăn";
            this.foodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.foodLabel.Click += new System.EventHandler(this.foodLabel_Click);
            this.foodLabel.MouseEnter += new System.EventHandler(this.foodLabel_MouseEnter);
            this.foodLabel.MouseLeave += new System.EventHandler(this.foodLabel_MouseLeave);
            // 
            // computerLabel
            // 
            this.computerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.computerLabel.Image = ((System.Drawing.Image)(resources.GetObject("computerLabel.Image")));
            this.computerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.computerLabel.Location = new System.Drawing.Point(0, 40);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.computerLabel.Size = new System.Drawing.Size(130, 37);
            this.computerLabel.TabIndex = 2;
            this.computerLabel.Text = "     Máy tính";
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.computerLabel.Click += new System.EventHandler(this.computerLabel_Click);
            this.computerLabel.MouseEnter += new System.EventHandler(this.computerLabel_MouseEnter);
            this.computerLabel.MouseLeave += new System.EventHandler(this.computerLabel_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 577);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label accountsLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.Label exitLabel;
    }
}