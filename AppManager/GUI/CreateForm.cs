using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI {
    public partial class CreateForm : Form {
        AccountsForm accountsForm;
        bool IsDown;
        int dx;
        int dy;

        public CreateForm(AccountsForm accountsForm) {
            this.accountsForm = accountsForm;
            InitializeComponent();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void okLabel_MouseEnter(object sender, EventArgs e) {
            okLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void okLabel_Mouseleave(object sender, EventArgs e) {
            okLabel.BackColor = Color.FromArgb(115, 115, 117);
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

        private void okLabel_Click(object sender, EventArgs e) {
            try {
                if (usernameTextBox.Text == "" || passTextBox.Text == "" || rePassTextBox.Text == "") throw new Exception("Hãy nhập vào chỗ còn trống");
                if (passTextBox.Text != rePassTextBox.Text) throw new Exception("Mật khẩu không khớp");
                

                Account account = new Account() {
                    username = usernameTextBox.Text,
                    password = passTextBox.Text,
                    group = 2
                };

                DetailAccount detail = new DetailAccount() {
                    name = nameTextBox.Text,
                    phone = phoneTextBox.Text,
                    username = account.username,
                    account = account
                };
                if (ageTextBox.Text != "") detail.age = Int32.Parse(ageTextBox.Text);
                if (cmndTextBox.Text != "") detail.cmnd = Int32.Parse(cmndTextBox.Text);

                DTO.Timer timer = new DTO.Timer() {
                    money_left = moneyTextBox.Text == "" ? 0 : float.Parse(moneyTextBox.Text),
                    username = account.username
                };
                timer.time_left = DTO.Timer.MoneyToTime(timer.money_left);

                if(!new AccountBUS().CreateAccount(account, detail, timer)) throw new Exception("Tài khoản đã tồn tại");

                usernameTextBox.Text = "";
                passTextBox.Text = "";
                rePassTextBox.Text = "";
                nameTextBox.Text = "";
                phoneTextBox.Text = "";
                ageTextBox.Text = "";
                cmndTextBox.Text = "";
                moneyTextBox.Text = "";
                informLabel.Text = "Tạo thành công";

                accountsForm.loadClientAccounts();
            }
            catch(Exception ex) {
                informLabel.Text = ex.Message;
            }
        }

        private void closeLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.Close();
            }
        }
    }
}
