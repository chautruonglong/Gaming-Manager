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
using System.Threading;

namespace GUI {
    public partial class LoginForm : UserControl {
        Form rootForm;

        public LoginForm() {
            InitializeComponent();
        }

        public LoginForm(Form rootForm) {
            this.rootForm = rootForm;
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void signInLabel_MouseEnter(object sender, EventArgs e) {
            signInLabel.BackColor = Color.FromArgb(63, 63, 65);
        }
        private void signInLabel_MouseLeave(object sender, EventArgs e) {
            signInLabel.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void signInLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                usernameTextBox.Text = usernameTextBox.Text.Trim();
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "") {
                    AccountBUS login = new AccountBUS();
                    if (login.IsLoginSever(usernameTextBox.Text, passwordTextBox.Text)) {
                        for (int i = 0; i < 100; ++i) {
                            progressBar1.Value = i;
                            Thread.Sleep(10);
                        }
                        this.Hide();
                        usernameTextBox.Text = "";
                        passwordTextBox.Text = "";
                        informLabel.Text = "";
                        progressBar1.Value = 0;
                    }
                    else informLabel.Text = "Tài khoản hoặc mật khẩu không đúng";
                }
                else {
                    informLabel.Text = "Hãy nhập chỗ còn để trống";
                }
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                usernameTextBox.Text = usernameTextBox.Text.Trim();
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "") {
                    AccountBUS login = new AccountBUS();
                    if (login.IsLoginSever(usernameTextBox.Text, passwordTextBox.Text)) {
                        for (int i = 0; i < 100; ++i) {
                            progressBar1.Value = i;
                            Thread.Sleep(10);
                        }
                        this.Hide();
                        usernameTextBox.Text = "";
                        passwordTextBox.Text = "";
                        informLabel.Text = "";
                        progressBar1.Value = 0;
                    }
                    else informLabel.Text = "Tài khoản hoặc mật khẩu không đúng";
                }
                else {
                    informLabel.Text = "Hãy nhập chỗ còn để trống";
                }
            }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                usernameTextBox.Text = usernameTextBox.Text.Trim();
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "") {
                    AccountBUS login = new AccountBUS();
                    if (login.IsLoginSever(usernameTextBox.Text, passwordTextBox.Text)) {
                        for (int i = 0; i < 100; ++i) {
                            progressBar1.Value = i;
                            Thread.Sleep(10);
                        }
                        this.Hide();
                        usernameTextBox.Text = "";
                        passwordTextBox.Text = "";
                        informLabel.Text = "";
                        progressBar1.Value = 0;
                    }
                    else informLabel.Text = "Tài khoản hoặc mật khẩu không đúng";
                }
                else {
                    informLabel.Text = "Hãy nhập chỗ còn để trống";
                }
            }
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                usernameTextBox.Text = usernameTextBox.Text.Trim();
                if (usernameTextBox.Text != "" && passwordTextBox.Text != "") {
                    AccountBUS login = new AccountBUS();
                    if (login.IsLoginSever(usernameTextBox.Text, passwordTextBox.Text)) {
                        for (int i = 0; i < 100; ++i) {
                            progressBar1.Value = i;
                            Thread.Sleep(10);
                        }
                        this.Hide();
                        usernameTextBox.Text = "";
                        passwordTextBox.Text = "";
                        informLabel.Text = "";
                        progressBar1.Value = 0;
                    }
                    else informLabel.Text = "Tài khoản hoặc mật khẩu không đúng";
                }
                else {
                    informLabel.Text = "Hãy nhập chỗ còn để trống";
                }
            }
        }
    }
}
