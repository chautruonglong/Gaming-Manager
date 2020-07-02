using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI {
    public partial class FoodsForm : UserControl {
        public FoodsForm() {
            InitializeComponent();
            loadFoodLabels();
        }

        public void loadFoodLabels() {
            FoodBUS foodBUS = new FoodBUS();
            Food[] foods = foodBUS.GetListFood();
            int rows = foods.Length / 4 + 1;
            int count = 0;
            int vgap = 30, hgap = 30;
            foodsPanel.Controls.Clear();
            try {           
                for (int i = 0; i < rows; ++i) {
                    for (int j = 0; j < 4; ++j) {
                        FoodLabel foodLabel = new FoodLabel(foods[count++], this);
                        foodLabel.Location = new Point(hgap + j * foodLabel.Size.Width, vgap + i * foodLabel.Size.Height);
                        foodsPanel.Controls.Add(foodLabel);
                        hgap += 30;
                    }
                    vgap += 30;
                    hgap = 30;
                }
            }
            catch(Exception e) {}
        }

        private void addFoodLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                new AddFoodForm(this).Visible = true;
            }
        }

        private void addFoodLabel_MouseEnter(object sender, EventArgs e) {
            addFoodLabel.BackColor = Color.LightGray;
        }

        private void addFoodLabel_MouseLeave(object sender, EventArgs e) {
            addFoodLabel.BackColor = Color.FromName("Control");
        }
    }
}
