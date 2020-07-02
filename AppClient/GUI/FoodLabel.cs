using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI {
    class FoodLabel : Label {
        private Food food;
        private DataGridView dataGridView;
       
        public FoodLabel(Food f, DataGridView dataGridView) {
            this.food = f;  
            this.AutoSize = false;
            this.Text = food.name + " - " + string.Format("{0:n0}", food.cost);
            this.Image = Image.FromStream(new MemoryStream(food.image));
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.TopCenter;
            this.Size = new Size(160, 140);
            this.MouseDown += FoodLabel_MouseDown;
            this.MouseEnter += FoodLabel_MouseEnter;
            this.MouseLeave += FoodLabel_MouseLeave;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dataGridView = dataGridView;
        }

        private void FoodLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.dataGridView.Rows.Add(this.food.name, this.food.cost);
            }
        }

        private void FoodLabel_MouseEnter(object sender, EventArgs e) {
            this.BackColor = Color.LightGray;
        }

        private void FoodLabel_MouseLeave(object sender, EventArgs e) {
            this.BackColor = Color.FromName("ControlLight");
        }

    }
}
