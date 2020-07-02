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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.sendLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // contentTextBox
            // 
            this.contentTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentTextBox.Location = new System.Drawing.Point(161, 457);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(458, 62);
            this.contentTextBox.TabIndex = 0;
            this.contentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contentTextBox_KeyDown);
            // 
            // sendLabel
            // 
            this.sendLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sendLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sendLabel.Image = ((System.Drawing.Image)(resources.GetObject("sendLabel.Image")));
            this.sendLabel.Location = new System.Drawing.Point(625, 457);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(60, 62);
            this.sendLabel.TabIndex = 1;
            this.sendLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sendLabel_MouseDown);
            // 
            // messagePanel
            // 
            this.messagePanel.AutoScroll = true;
            this.messagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.messagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messagePanel.Location = new System.Drawing.Point(161, 4);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(524, 437);
            this.messagePanel.TabIndex = 2;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.contentTextBox);
            this.Name = "ChatForm";
            this.Size = new System.Drawing.Size(846, 528);
            this.VisibleChanged += new System.EventHandler(this.ChatForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.Panel messagePanel;
    }
}
