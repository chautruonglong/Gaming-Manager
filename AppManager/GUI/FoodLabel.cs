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
        private FoodsForm foodsForm;

        private ContextMenuStrip contextMenuStrip;
        private ToolStripItem deleteItem;
        private ToolStripItem updateItem;
        private ToolStripItem historyItem;

        public FoodLabel(Food f, FoodsForm foodsForm) {
            contextMenuStrip = new ContextMenuStrip();
            deleteItem = new ToolStripMenuItem();
            updateItem = new ToolStripMenuItem();
            historyItem = new ToolStripMenuItem();

            deleteItem.Text = "Xóa";
            deleteItem.MouseDown += deleteItem_MouseDown;

            updateItem.Text = "Sửa";
            updateItem.MouseDown += updateItem_MouseDown;

            historyItem.Text = "Xem lịch sử";
            historyItem.MouseDown += historyItem_MouseDown;


            contextMenuStrip.Items.AddRange(new ToolStripItem[] {
                deleteItem,
                updateItem,
                historyItem,
            });



            this.foodsForm = foodsForm;
            this.food = f;
            this.AutoSize = false;
            this.Text = food.name + " - " + string.Format("{0:n0}", food.cost);
            this.Image = Image.FromStream(new MemoryStream(food.image));
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.TopCenter;
            this.Size = new Size(160, 140);
            this.MouseDown += FoodLabel_MouseDown;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        }

        private void FoodLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                contextMenuStrip.Show(this, new Point(80, 60));
            }
        }

        private void deleteItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                new FoodBUS().DeleteFood(food.food_id);
                foodsForm.loadFoodLabels();
            }
        }

        private void updateItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                AddFoodForm addFoodForm = new AddFoodForm(foodsForm);
                MemoryStream ms = new MemoryStream(food.image);
                addFoodForm.TitleLabel.Text = "Sửa món ăn";
                addFoodForm.NameTextBox.Text = food.name;
                addFoodForm.CostTextBox.Text = food.cost.ToString();
                addFoodForm.ImagePictureBox.Image = Image.FromStream(ms);
                addFoodForm.newFood.food_id = food.food_id;
                addFoodForm.Visible = true;
                new FoodBUS().InsertOrUpdateFood(food);
            }
        }

        private void historyItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                HistoryForm historyFoodForm = new HistoryForm();
                HistoryFood[] historyFoods = new HistoryFoodBUS().GetHistoryFoodsFromFoodId(food.food_id);
                try {
                    for (int i = 0; i < historyFoods.Length; ++i) {
                        historyFoodForm.DataGridView.Rows.Add(historyFoods[i].username, historyFoods[i].time);
                    }
                }
                catch (Exception ex) { }
                historyFoodForm.Visible = true;
            }
        }
    }
}
