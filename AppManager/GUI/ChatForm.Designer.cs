namespace GUI {
    partial class ChatForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.closeLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.sendLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeLabel
            // 
            this.closeLabel.Image = ((System.Drawing.Image)(resources.GetObject("closeLabel.Image")));
            this.closeLabel.Location = new System.Drawing.Point(313, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(36, 31);
            this.closeLabel.TabIndex = 3;
            this.closeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseDown);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.closeLabel);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(350, 38);
            this.headerPanel.TabIndex = 5;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.titleLabel.Location = new System.Drawing.Point(135, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(77, 21);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Nhắn tin";
            // 
            // contentTextBox
            // 
            this.contentTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.contentTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentTextBox.Location = new System.Drawing.Point(12, 426);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(277, 43);
            this.contentTextBox.TabIndex = 6;
            this.contentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contentTextBox_KeyDown);
            // 
            // sendLabel
            // 
            this.sendLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sendLabel.Image = ((System.Drawing.Image)(resources.GetObject("sendLabel.Image")));
            this.sendLabel.Location = new System.Drawing.Point(295, 426);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(43, 43);
            this.sendLabel.TabIndex = 7;
            this.sendLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sendLabel_MouseDown);
            this.sendLabel.MouseEnter += new System.EventHandler(this.sendLabel_MouseEnter);
            this.sendLabel.MouseLeave += new System.EventHandler(this.sendLabel_MouseLeave);
            // 
            // messagePanel
            // 
            this.messagePanel.AutoScroll = true;
            this.messagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.messagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagePanel.Location = new System.Drawing.Point(0, 45);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(350, 375);
            this.messagePanel.TabIndex = 8;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 483);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Label titleLabel;
    }
}