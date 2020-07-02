namespace GUI {
    partial class FoodsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodsForm));
            this.addFoodLabel = new System.Windows.Forms.Label();
            this.foodsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addFoodLabel
            // 
            this.addFoodLabel.Image = ((System.Drawing.Image)(resources.GetObject("addFoodLabel.Image")));
            this.addFoodLabel.Location = new System.Drawing.Point(692, 426);
            this.addFoodLabel.Name = "addFoodLabel";
            this.addFoodLabel.Size = new System.Drawing.Size(75, 51);
            this.addFoodLabel.TabIndex = 4;
            this.addFoodLabel.Text = "Thêm món ăn";
            this.addFoodLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addFoodLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addFoodLabel_MouseDown);
            this.addFoodLabel.MouseEnter += new System.EventHandler(this.addFoodLabel_MouseEnter);
            this.addFoodLabel.MouseLeave += new System.EventHandler(this.addFoodLabel_MouseLeave);
            // 
            // foodsPanel
            // 
            this.foodsPanel.AutoScroll = true;
            this.foodsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.foodsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodsPanel.Location = new System.Drawing.Point(0, 0);
            this.foodsPanel.Name = "foodsPanel";
            this.foodsPanel.Size = new System.Drawing.Size(799, 413);
            this.foodsPanel.TabIndex = 5;
            // 
            // FoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.addFoodLabel);
            this.Controls.Add(this.foodsPanel);
            this.Name = "FoodsForm";
            this.Size = new System.Drawing.Size(799, 492);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addFoodLabel;
        private System.Windows.Forms.Panel foodsPanel;
    }
}
