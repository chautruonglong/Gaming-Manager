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
    public partial class MainForm : Form {
        private LoginForm loginForm;
        private AccountForm accountForm;
        private GameForm gameForm;
        private FoodsForm foodForm;
        private ChatForm chatForm;

        private void exit(object sender, EventArgs e) {
            this.Hide();
            this.loginForm.Show();
        }

        public MainForm(LoginForm loginForm) {
            InitializeComponent();

            this.loginForm = loginForm;

            this.accountForm = new AccountForm(exit) {
                Visible = true,
                Location = new Point(130, 88)
            };

            this.gameForm = new GameForm() {
                Visible = false,
                Location = new Point(130, 88)
            };

            this.chatForm = new ChatForm() {
                Visible = false,
                Location = new Point(130, 88)
            };

            this.foodForm = new FoodsForm(this.chatForm) {
                Visible = false,
                Location = new Point(130, 88)
            };

            this.Controls.Add(this.accountForm);
            this.Controls.Add(this.gameForm);
            this.Controls.Add(this.foodForm);
            this.Controls.Add(this.chatForm);
        }

        // MainForm
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            this.loginForm.Close();
        }

        // headerPanel
        bool IsDown;
        int dx, dy;
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

        // accountLabel
        private void accountLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.accountForm.Show();
                this.gameForm.Hide();
                this.foodForm.Hide();
                this.chatForm.Hide();
                this.signLabel.Location = new Point(0, this.accountLabel.Location.Y + this.accountLabel.Height);
            }
        }

        private void accountLabel_MouseEnter(object sender, EventArgs e) {
            accountLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void accountLabel_MouseLeave(object sender, EventArgs e) {
            accountLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        // gameLabel
        private void gameLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.accountForm.Hide();
                this.gameForm.Show();
                this.foodForm.Hide();
                this.chatForm.Hide();
                this.signLabel.Location = new Point(0, this.gameLabel.Location.Y + this.gameLabel.Height);
            }
        }

        private void gameLabel_MouseEnter(object sender, EventArgs e) {
            gameLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void gameLabel_MouseLeave(object sender, EventArgs e) {
            gameLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        // foodLabel
        private void foodLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.accountForm.Hide();
                this.gameForm.Hide();
                this.foodForm.Show();
                this.chatForm.Hide();
                this.signLabel.Location = new Point(0, this.foodLabel.Location.Y + this.foodLabel.Height);
            }
        }

        private void foodLabel_MouseEnter(object sender, EventArgs e) {
            foodLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void foodLabel_MouseLeave(object sender, EventArgs e) {
            foodLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        // chatLabel
        private void chatLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.accountForm.Hide();
                this.gameForm.Hide();
                this.foodForm.Hide();
                this.chatForm.Show();
                this.signLabel.Location = new Point(0, this.chatLabel.Location.Y + this.chatLabel.Height);
            }
        }

        private void chatLabel_MouseEnter(object sender, EventArgs e) {
            chatLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void chatLabel_MouseLeave(object sender, EventArgs e) {
            chatLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        // minimizeLabel
        private void minimizeLabel_MouseEnter(object sender, EventArgs e) {
            minimizeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void minimizeLabel_MouseLeave(object sender, EventArgs e) {
            minimizeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void minimizeLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        // closeLabel
        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void closeLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Application.Exit();
            }
        }

        // exitLabel
        private void exitLabel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.Hide();
                loginForm.Show();
            }
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e) {
            exitLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e) {
            exitLabel.BackColor = Color.FromArgb(45, 45, 50);
        }

        // helpLabel
        private void helpLabel_MouseEnter(object sender, EventArgs e) {
            helpLabel.BackColor = Color.FromArgb(63, 63, 65);
            string message = "Phần mềm quản lý phòng Game\n" +
                             "Châu Trường Long\n" +
                             "Nguyễn Thị Minh Châu\n" +
                             "Hồ Nguyên Vũ";
            new ToolTip().Show(message, this, helpLabel.Location.X + helpLabel.Width, helpLabel.Location.Y + helpLabel.Height, 1000);
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e) {
            if(this.Visible == true) {
                this.accountForm.loadInfoAccount(this.loginForm.UsernameTextBox.Text);
            }
            else {
                this.accountForm.Stop();
            }
        }

        private void helpLabel_MouseLeave(object sender, EventArgs e) {
            helpLabel.BackColor = Color.FromArgb(45, 45, 50);
        }
    }
}
