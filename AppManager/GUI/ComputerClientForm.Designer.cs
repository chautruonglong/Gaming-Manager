namespace GUI {
    partial class ComputerClientForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerClientForm));
            this.computersPanel = new System.Windows.Forms.Panel();
            this.showIpv4Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // computersPanel
            // 
            this.computersPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.computersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computersPanel.Location = new System.Drawing.Point(0, 0);
            this.computersPanel.Name = "computersPanel";
            this.computersPanel.Size = new System.Drawing.Size(799, 425);
            this.computersPanel.TabIndex = 0;
            // 
            // showIpv4Label
            // 
            this.showIpv4Label.Image = ((System.Drawing.Image)(resources.GetObject("showIpv4Label.Image")));
            this.showIpv4Label.Location = new System.Drawing.Point(754, 447);
            this.showIpv4Label.Name = "showIpv4Label";
            this.showIpv4Label.Size = new System.Drawing.Size(31, 30);
            this.showIpv4Label.TabIndex = 1;
            this.showIpv4Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showIpv4Label_MouseDown);
            this.showIpv4Label.MouseEnter += new System.EventHandler(this.showIpv4Label_MouseEnter);
            this.showIpv4Label.MouseLeave += new System.EventHandler(this.showIpv4Label_MouseLeave);
            // 
            // ComputerClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.showIpv4Label);
            this.Controls.Add(this.computersPanel);
            this.Name = "ComputerClientForm";
            this.Size = new System.Drawing.Size(799, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel computersPanel;
        private System.Windows.Forms.Label showIpv4Label;
    }
}
