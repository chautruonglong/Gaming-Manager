using BUS;
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
    public partial class LoginForm : Form {
        private MainForm mainForm;

        public LoginForm() {
            InitializeComponent();
            this.accountPanel.Location = new Point((this.Width - this.accountPanel.Width) / 2, (this.Height - this.accountPanel.Height) / 2);
            this.accountPanel.Anchor = AnchorStyles.None;
            this.mainForm = new MainForm(this);
        }

        private void closeLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.accountPanel.Hide();
            }
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            this.closeLabel.BackColor = Color.LightGray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            this.closeLabel.BackColor = Color.FromArgb(45, 48, 48);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.accountPanel.Show();
            }
        }

        private void okButton_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                AccountBUS accountBUS = new AccountBUS();
                TimerBUS timerBUS = new TimerBUS();
                try {
                    this.usernameText.Text = this.usernameText.Text.Trim();
                    if(this.usernameText.Text == "") throw new Exception("Hãy nhập tài khoản");
                    if(this.passwordText.Text == "") throw new Exception("Hãy nhập mật khẩu");
                    if(!accountBUS.IsLogin(this.usernameText.Text, this.passwordText.Text)) throw new Exception("Tài khoản hoặc mật khẩu không đúng");
                    if(timerBUS.GetTimeLeft(this.usernameText.Text) <= 0) throw new Exception("Tài khoản bạn không còn tiền");
                    this.Hide();
                    mainForm.Show();   
                }
                catch (Exception ex) {
                    this.informLabel.Text = ex.Message;
                }
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                AccountBUS accountBUS = new AccountBUS();
                TimerBUS timerBUS = new TimerBUS();
                try {
                    this.usernameText.Text = this.usernameText.Text.Trim();
                    if(this.usernameText.Text == "") throw new Exception("Hãy nhập tài khoản");
                    if(this.passwordText.Text == "") throw new Exception("Hãy nhập mật khẩu");
                    if(!accountBUS.IsLogin(this.usernameText.Text, this.passwordText.Text)) throw new Exception("Tài khoản hoặc mật khẩu không đúng");
                    if(timerBUS.GetTimeLeft(this.usernameText.Text) <= 0) throw new Exception("Tài khoản bạn không còn tiền");
                    this.Hide();
                    mainForm.Show();
                }
                catch(Exception ex) {
                    this.informLabel.Text = ex.Message;
                }
            }
        }

        private void usernameText_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                AccountBUS accountBUS = new AccountBUS();
                TimerBUS timerBUS = new TimerBUS();
                try {
                    this.usernameText.Text = this.usernameText.Text.Trim();
                    if(this.usernameText.Text == "") throw new Exception("Hãy nhập tài khoản");
                    if(this.passwordText.Text == "") throw new Exception("Hãy nhập mật khẩu");
                    if(!accountBUS.IsLogin(this.usernameText.Text, this.passwordText.Text)) throw new Exception("Tài khoản hoặc mật khẩu không đúng");
                    if(timerBUS.GetTimeLeft(this.usernameText.Text) <= 0) throw new Exception("Tài khoản bạn không còn tiền");
                    this.Hide();
                    mainForm.Show();
                }
                catch(Exception ex) {
                    this.informLabel.Text = ex.Message;
                }
            }
        }

        public TextBox UsernameTextBox {
            get=>usernameText;
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e) {
            if(this.Visible == true) {
                usernameText.Text = "";
                passwordText.Text = "";
                informLabel.Text = "";
            }
        }
    }
}
