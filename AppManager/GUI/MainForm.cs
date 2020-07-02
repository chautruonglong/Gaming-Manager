using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class MainForm : Form {
        LoginForm loginForm;
        ComputerClientForm clientsForm;
        FoodsForm foodsForm;
        AccountsForm accountsForm;

        int dx;
        int dy;
        bool IsDown;

        public MainForm() {
            loginForm = new LoginForm(this);
            clientsForm = new ComputerClientForm();
            foodsForm = new FoodsForm();
            accountsForm = new AccountsForm();

            loginForm.Location = new Point(0, 85);
            this.Controls.Add(loginForm);

            clientsForm.Location = new Point(130, 85);
            this.Controls.Add(clientsForm);

            foodsForm.Location = new Point(130, 85);
            this.Controls.Add(foodsForm);

            accountsForm.Location = new Point(130, 85); ;
            this.Controls.Add(accountsForm);

            InitializeComponent();
        }

        private void minimizeLabel_MouseEnter(object sender, EventArgs e) {
            minimizeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void minimizeLabel_MouseLeave(object sender, EventArgs e) {
            minimizeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void computerLabel_MouseEnter(object sender, EventArgs e) {
            computerLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void computerLabel_MouseLeave(object sender, EventArgs e) {
            computerLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        private void computerLabel_Click(object sender, EventArgs e) {
            signLabel.Location = new Point(0, computerLabel.Location.Y + computerLabel.Height);
            foodsForm.Hide();
            accountsForm.Hide();
            clientsForm.Show();
        }

        private void foodLabel_MouseEnter(object sender, EventArgs e) {
            foodLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void foodLabel_MouseLeave(object sender, EventArgs e) {
            foodLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        private void foodLabel_Click(object sender, EventArgs e) {
            signLabel.Location = new Point(0, foodLabel.Location.Y + foodLabel.Height);
            clientsForm.Hide();
            accountsForm.Hide();
            foodsForm.Show();           
        }

        private void accountsLabel_MouseEnter(object sender, EventArgs e) {
            accountsLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void accountsLabel_MouseLeave(object sender, EventArgs e) {
            accountsLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        private void accountsLabel_Click(object sender, EventArgs e) {
            signLabel.Location = new Point(0, accountsLabel.Location.Y + accountsLabel.Height);
            clientsForm.Hide();
            foodsForm.Hide();
            accountsForm.Show();
        }

        private void helpLabel_MouseEnter(object sender, EventArgs e) {
            helpLabel.BackColor = Color.FromArgb(63, 63, 65);
            string message = "Phần mềm quản lý phòng Game\n" +
                             "Châu Trường Long\n" +
                             "Nguyễn Thị Minh Châu\n" +
                             "Hồ Nguyên Vũ";
            new ToolTip().Show(message, this, helpLabel.Location.X + helpLabel.Width, helpLabel.Location.Y + helpLabel.Height, 1000);
        }

        private void helpLabel_MouseLeave(object sender, EventArgs e) {
            helpLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                IsDown = true;
                dx = e.X;
                dy = e.Y;
            }
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e) {
            if(IsDown == true) {
                this.SetDesktopLocation(MousePosition.X - this.dx, MousePosition.Y - this.dy);
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e) {
            IsDown = false;
        }

        private void exitLabel_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Xác nhận thoát", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                loginForm.Show();
            }          
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e) {
            exitLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e) {
            exitLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        private void closeLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                Application.Exit();
            }
        }

        private void minimizeLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
