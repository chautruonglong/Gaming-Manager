using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI {
    public partial class AddFoodForm : Form {
        public Food newFood { get; set; }
        bool IsDown;
        int dx;
        int dy;
        FoodsForm foodsForm;

        public AddFoodForm(FoodsForm foodsForm) {
            InitializeComponent();
            this.foodsForm = foodsForm;
            newFood = new Food();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void openDialogButton_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            fileDialog.ShowDialog();

            if(fileDialog.FileName != "") imagePictureBox.Image = Image.FromFile(fileDialog.FileName);
        }

        private void okLabel_Click(object sender, EventArgs e) {
            try {
                if(nameTextBox.Text == "") throw new Exception("Hãy nhập tên món");
                try { float.Parse(costTextBox.Text); } catch(Exception ef) { throw new Exception("Giá món ăn bị lỗi"); }
                if(imagePictureBox.Image == null) throw new Exception("Hãy thêm hình ảnh");

                MemoryStream ms = new MemoryStream();
                imagePictureBox.Image.Save(ms, imagePictureBox.Image.RawFormat);

                newFood.name = nameTextBox.Text;
                newFood.cost = float.Parse(costTextBox.Text);
                newFood.image = ms.ToArray();

                new FoodBUS().InsertOrUpdateFood(newFood);
                foodsForm.loadFoodLabels();

                this.Close();
            }
            catch(Exception ex) {
                informLabel.Text = ex.Message;
            }
        }

        private void okLabel_MouseEnter(object sender, EventArgs e) {
            okLabel.BackColor = Color.LightGray;
        }

        private void okLabel_MouseLeave(object sender, EventArgs e) {
            okLabel.BackColor = Color.FromName("AppWorkspace");
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                IsDown = true;
                dx = e.X;
                dy = e.Y;
            }
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e) {
            if (IsDown == true) {
                this.SetDesktopLocation(MousePosition.X - this.dx, MousePosition.Y - this.dy);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e) {
            IsDown = false;
        }

        private void closeLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.Close();
            }
        }
    }
}
