namespace GUI {
    partial class AddFoodForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFoodForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.openDialogButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.okLabel = new System.Windows.Forms.Label();
            this.informLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.closeLabel);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(313, 51);
            this.headerPanel.TabIndex = 8;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(101, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(126, 21);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Thêm món mới";
            // 
            // closeLabel
            // 
            this.closeLabel.Image = ((System.Drawing.Image)(resources.GetObject("closeLabel.Image")));
            this.closeLabel.Location = new System.Drawing.Point(279, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(36, 32);
            this.closeLabel.TabIndex = 2;
            this.closeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeLabel_MouseDown);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên món ăn";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(118, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(143, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imagePictureBox.Location = new System.Drawing.Point(42, 197);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(219, 202);
            this.imagePictureBox.TabIndex = 11;
            this.imagePictureBox.TabStop = false;
            // 
            // openDialogButton
            // 
            this.openDialogButton.Location = new System.Drawing.Point(186, 405);
            this.openDialogButton.Name = "openDialogButton";
            this.openDialogButton.Size = new System.Drawing.Size(75, 23);
            this.openDialogButton.TabIndex = 12;
            this.openDialogButton.Text = "Chọn";
            this.openDialogButton.UseVisualStyleBackColor = true;
            this.openDialogButton.Click += new System.EventHandler(this.openDialogButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hình ảnh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giá";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(118, 138);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(143, 20);
            this.costTextBox.TabIndex = 15;
            // 
            // okLabel
            // 
            this.okLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.okLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okLabel.Location = new System.Drawing.Point(231, 451);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(68, 28);
            this.okLabel.TabIndex = 16;
            this.okLabel.Text = "Đồng ý";
            this.okLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okLabel.Click += new System.EventHandler(this.okLabel_Click);
            this.okLabel.MouseEnter += new System.EventHandler(this.okLabel_MouseEnter);
            this.okLabel.MouseLeave += new System.EventHandler(this.okLabel_MouseLeave);
            // 
            // informLabel
            // 
            this.informLabel.AutoSize = true;
            this.informLabel.ForeColor = System.Drawing.Color.Red;
            this.informLabel.Location = new System.Drawing.Point(39, 432);
            this.informLabel.Name = "informLabel";
            this.informLabel.Size = new System.Drawing.Size(0, 13);
            this.informLabel.TabIndex = 17;
            // 
            // AddFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 498);
            this.Controls.Add(this.informLabel);
            this.Controls.Add(this.okLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openDialogButton);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFoodForm";
            this.Text = "AddFoodForm";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button openDialogButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label okLabel;
        private System.Windows.Forms.Label informLabel;

        public System.Windows.Forms.TextBox NameTextBox {
            get => nameTextBox;
            set => nameTextBox = value;
        }

        public System.Windows.Forms.TextBox CostTextBox {
            get => costTextBox;
            set => costTextBox = value;
        }

        public System.Windows.Forms.PictureBox ImagePictureBox {
            get => imagePictureBox;
            set => imagePictureBox = value;
        }

        public System.Windows.Forms.Label TitleLabel {
            get => titleLabel;
            set => titleLabel = value;
        }
    }
}