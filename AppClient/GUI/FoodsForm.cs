using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI {
    public partial class FoodsForm : UserControl {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteItem;
        private ChatForm chatForm;

        public FoodsForm(ChatForm chatForm) {
            InitializeComponent();
            loadFoodLabels();
            this.chatForm = chatForm;

            this.deleteItem = new ToolStripMenuItem();
            this.contextMenuStrip = new ContextMenuStrip();

            this.deleteItem.Text = "Xóa";
            this.deleteItem.MouseDown += deleteItem_MouseDown;

            this.contextMenuStrip.Items.Add(this.deleteItem);
        }

        public void loadFoodLabels() {
            FoodBUS foodBUS = new FoodBUS();
            Food[] foods = foodBUS.GetListFood();
            int rows = foods.Length / 4 + 1;
            int count = 0;
            int vgap = 30, hgap = 30;

            foodsPanel.Controls.Clear();
            try {
                for(int i = 0; i < rows; ++i) {
                    for(int j = 0; j < 3; ++j) {
                        FoodLabel foodLabel = new FoodLabel(foods[count++], this.dataGridView);
                        foodLabel.Location = new Point(hgap + j * foodLabel.Size.Width, vgap + i * foodLabel.Size.Height);
                        foodsPanel.Controls.Add(foodLabel);
                        hgap += 30;
                    }
                    vgap += 30;
                    hgap = 30;
                }
            }
            catch(Exception e) { }
        }

        private void deleteItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                try {                
                    this.dataGridView.Rows.RemoveAt(this.dataGridView.CurrentCell.RowIndex);
                }
                catch(Exception ex) { }
            }
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                int row = e.RowIndex;
                if(row > -1) {
                    DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, row];
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                    this.contextMenuStrip.Show(new Point(MousePosition.X, MousePosition.Y));
                }
            }
        }

        private void callLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
;               string messageFood = "||----ĐỒ ĂN----||\n";
                for(int i = 0; i < this.dataGridView.Rows.Count - 1; ++i) {
                    messageFood += (i + 1).ToString() + "." + this.dataGridView.Rows[i].Cells[0].Value.ToString();
                    messageFood += "---" + this.dataGridView.Rows[i].Cells[1].Value.ToString() + "\n";
                }
                if(this.dataGridView.Rows.Count > 1 && this.chatForm.computerClientConnection.computerClientChat != null && this.chatForm.computerClientConnection.computerClientChat.IsConnected) {
                    this.chatForm.computerClientConnection.computerClientChat.SendMessage(messageFood);
                    this.chatForm.messagesNotSowYet.Enqueue(new Message() {
                        content = messageFood,
                        isSend = true
                    });
                    this.dataGridView.Rows.Clear();
                }
            }
        }
    }
}
