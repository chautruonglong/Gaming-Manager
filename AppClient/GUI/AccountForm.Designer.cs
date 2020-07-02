namespace GUI {
    partial class AccountForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.informLabel = new System.Windows.Forms.Label();
            this.rePassText = new System.Windows.Forms.TextBox();
            this.newPassText = new System.Windows.Forms.TextBox();
            this.oldPassText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.rePassLabel = new System.Windows.Forms.Label();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.historyUsedLabel = new System.Windows.Forms.Label();
            this.historyFoodLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmndTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topPanel.Controls.Add(this.usernameLabel);
            this.topPanel.Location = new System.Drawing.Point(0, 2);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(842, 130);
            this.topPanel.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Image = ((System.Drawing.Image)(resources.GetObject("usernameLabel.Image")));
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.Location = new System.Drawing.Point(311, 0);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(225, 119);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // informLabel
            // 
            this.informLabel.AutoSize = true;
            this.informLabel.BackColor = System.Drawing.Color.Silver;
            this.informLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informLabel.ForeColor = System.Drawing.Color.Red;
            this.informLabel.Location = new System.Drawing.Point(546, 436);
            this.informLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.informLabel.Name = "informLabel";
            this.informLabel.Size = new System.Drawing.Size(11, 13);
            this.informLabel.TabIndex = 45;
            this.informLabel.Text = " ";
            // 
            // rePassText
            // 
            this.rePassText.Location = new System.Drawing.Point(642, 402);
            this.rePassText.Name = "rePassText";
            this.rePassText.PasswordChar = '*';
            this.rePassText.Size = new System.Drawing.Size(174, 20);
            this.rePassText.TabIndex = 44;
            // 
            // newPassText
            // 
            this.newPassText.Location = new System.Drawing.Point(642, 354);
            this.newPassText.Name = "newPassText";
            this.newPassText.PasswordChar = '*';
            this.newPassText.Size = new System.Drawing.Size(174, 20);
            this.newPassText.TabIndex = 43;
            // 
            // oldPassText
            // 
            this.oldPassText.Location = new System.Drawing.Point(642, 304);
            this.oldPassText.Name = "oldPassText";
            this.oldPassText.PasswordChar = '*';
            this.oldPassText.Size = new System.Drawing.Size(174, 20);
            this.oldPassText.TabIndex = 42;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(741, 468);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 41;
            this.okButton.Text = "Đồng ý";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.okButton_MouseDown);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(643, 468);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 40;
            this.clearButton.Text = "Xóa";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clearButton_MouseDown);
            // 
            // rePassLabel
            // 
            this.rePassLabel.AutoSize = true;
            this.rePassLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassLabel.Location = new System.Drawing.Point(531, 406);
            this.rePassLabel.Name = "rePassLabel";
            this.rePassLabel.Size = new System.Drawing.Size(51, 15);
            this.rePassLabel.TabIndex = 39;
            this.rePassLabel.Text = "Nhập lại";
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassLabel.Location = new System.Drawing.Point(531, 358);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(81, 15);
            this.newPassLabel.TabIndex = 38;
            this.newPassLabel.Text = "Mật khẩu mới";
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassLabel.Location = new System.Drawing.Point(531, 308);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(73, 15);
            this.oldPassLabel.TabIndex = 37;
            this.oldPassLabel.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(497, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 45);
            this.label3.TabIndex = 36;
            this.label3.Text = "Đổi mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(200, 209);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(124, 23);
            this.time.TabIndex = 35;
            this.time.Text = "9:20";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money.Location = new System.Drawing.Point(200, 156);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(124, 23);
            this.money.TabIndex = 34;
            this.money.Text = "52,000";
            this.money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Image = ((System.Drawing.Image)(resources.GetObject("timeLabel.Image")));
            this.timeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeLabel.Location = new System.Drawing.Point(71, 199);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(105, 45);
            this.timeLabel.TabIndex = 33;
            this.timeLabel.Text = "Thời gian";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Image = ((System.Drawing.Image)(resources.GetObject("moneyLabel.Image")));
            this.moneyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moneyLabel.Location = new System.Drawing.Point(71, 146);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(74, 45);
            this.moneyLabel.TabIndex = 32;
            this.moneyLabel.Text = "Tiền";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // historyUsedLabel
            // 
            this.historyUsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyUsedLabel.Image = ((System.Drawing.Image)(resources.GetObject("historyUsedLabel.Image")));
            this.historyUsedLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyUsedLabel.Location = new System.Drawing.Point(497, 199);
            this.historyUsedLabel.Name = "historyUsedLabel";
            this.historyUsedLabel.Size = new System.Drawing.Size(180, 45);
            this.historyUsedLabel.TabIndex = 47;
            this.historyUsedLabel.Text = "Lịch sử đăng nhập";
            this.historyUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historyUsedLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.historyUsedLabel_MouseDown);
            this.historyUsedLabel.MouseEnter += new System.EventHandler(this.historyUsedLabel_MouseEnter);
            this.historyUsedLabel.MouseLeave += new System.EventHandler(this.historyUsedLabel_MouseLeave);
            // 
            // historyFoodLabel
            // 
            this.historyFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyFoodLabel.Image = ((System.Drawing.Image)(resources.GetObject("historyFoodLabel.Image")));
            this.historyFoodLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyFoodLabel.Location = new System.Drawing.Point(497, 146);
            this.historyFoodLabel.Name = "historyFoodLabel";
            this.historyFoodLabel.Size = new System.Drawing.Size(180, 45);
            this.historyFoodLabel.TabIndex = 46;
            this.historyFoodLabel.Text = "Lịch sử gọi món";
            this.historyFoodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historyFoodLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.historyFoodLabel_MouseDown);
            this.historyFoodLabel.MouseEnter += new System.EventHandler(this.historyFoodLabel_MouseEnter);
            this.historyFoodLabel.MouseLeave += new System.EventHandler(this.historyFoodLabel_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(94, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = " ";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(190, 394);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(174, 20);
            this.phoneTextBox.TabIndex = 55;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(190, 350);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(174, 20);
            this.ageTextBox.TabIndex = 54;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(190, 305);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 20);
            this.nameTextBox.TabIndex = 53;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(289, 468);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 52;
            this.saveButton.Text = "Lưu";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tuổi";
            // 
            // cmndTextBox
            // 
            this.cmndTextBox.Location = new System.Drawing.Point(190, 440);
            this.cmndTextBox.Name = "cmndTextBox";
            this.cmndTextBox.Size = new System.Drawing.Size(174, 20);
            this.cmndTextBox.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cmnd";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(71, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 45);
            this.label1.TabIndex = 59;
            this.label1.Text = "Thông tin tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmndTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.historyUsedLabel);
            this.Controls.Add(this.historyFoodLabel);
            this.Controls.Add(this.informLabel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rePassText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPassText);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.oldPassText);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.money);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.time);
            this.Controls.Add(this.rePassLabel);
            this.Controls.Add(this.oldPassLabel);
            this.Controls.Add(this.newPassLabel);
            this.Name = "AccountForm";
            this.Size = new System.Drawing.Size(846, 528);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label informLabel;
        private System.Windows.Forms.TextBox rePassText;
        private System.Windows.Forms.TextBox newPassText;
        private System.Windows.Forms.TextBox oldPassText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label rePassLabel;
        private System.Windows.Forms.Label newPassLabel;
        private System.Windows.Forms.Label oldPassLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label historyUsedLabel;
        private System.Windows.Forms.Label historyFoodLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cmndTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}
