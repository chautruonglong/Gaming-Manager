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
    public partial class PasswordForm : Form {
        string username;

        public PasswordForm(string username) {
            this.username = username;
            InitializeComponent();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void okButton_Click(object sender, EventArgs e) {
            try {
                if (passwordTextBox.Text == "" || rePasswordTextBox.Text == "") throw new Exception("Nhập chỗ còn trống");
                if (passwordTextBox.Text != rePasswordTextBox.Text) throw new Exception("Mật khẩu không khớp");
                Account account = new Account() {
                    username = username,
                    password = rePasswordTextBox.Text,
                    group = 2
                };
                new AccountBUS().InsertOrUpdate(account);
                this.Close();
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
