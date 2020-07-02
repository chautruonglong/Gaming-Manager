namespace GUI {
    partial class AccountsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.createLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.reloadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createLabel
            // 
            this.createLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createLabel.Image = ((System.Drawing.Image)(resources.GetObject("createLabel.Image")));
            this.createLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createLabel.Location = new System.Drawing.Point(686, 417);
            this.createLabel.Name = "createLabel";
            this.createLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.createLabel.Size = new System.Drawing.Size(98, 61);
            this.createLabel.TabIndex = 5;
            this.createLabel.Text = "Tạo tài khoản";
            this.createLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.createLabel_MouseDown);
            this.createLabel.MouseEnter += new System.EventHandler(this.createLabel_MouseEnter);
            this.createLabel.MouseLeave += new System.EventHandler(this.createLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(612, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 6;
            // 
            // findTextBox
            // 
            this.findTextBox.ForeColor = System.Drawing.Color.Black;
            this.findTextBox.Location = new System.Drawing.Point(647, 4);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(149, 20);
            this.findTextBox.TabIndex = 7;
            this.findTextBox.Text = "nhập tài khoản";
            this.findTextBox.TextChanged += new System.EventHandler(this.findTextBox_TextChanged);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 53);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(770, 345);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // reloadLabel
            // 
            this.reloadLabel.BackColor = System.Drawing.SystemColors.Control;
            this.reloadLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reloadLabel.Image = ((System.Drawing.Image)(resources.GetObject("reloadLabel.Image")));
            this.reloadLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reloadLabel.Location = new System.Drawing.Point(582, 417);
            this.reloadLabel.Name = "reloadLabel";
            this.reloadLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reloadLabel.Size = new System.Drawing.Size(98, 61);
            this.reloadLabel.TabIndex = 9;
            this.reloadLabel.Text = "Tải lại";
            this.reloadLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reloadLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reloadLabel_MouseDown);
            this.reloadLabel.MouseEnter += new System.EventHandler(this.reloadLabel_MouseEnter);
            this.reloadLabel.MouseLeave += new System.EventHandler(this.reloadLabel_MouseLeave);
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reloadLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createLabel);
            this.Name = "AccountsForm";
            this.Size = new System.Drawing.Size(799, 492);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label reloadLabel;
    }
}
