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
    public partial class AccountForm : UserControl {
        private DetailAccount detailAccount;
        private DTO.Timer timer;
        private HistoryFood []historyFood;
        private HistoryUsed []historyUsed;

        System.Windows.Forms.Timer checkTimer;

        public delegate void Exit(object sender, EventArgs e);
        event Exit exit;
        public AccountForm(Exit exit) {
            this.exit += exit;
            this.checkTimer = new System.Windows.Forms.Timer();
            InitializeComponent();
        }

        public void loadInfoAccount(string username) {
            this.detailAccount = new DetailAccountBUS().GetDetailAccount(username);
            this.timer = new TimerBUS().GetTimerAccount(username);
            this.historyFood = new HistoryFoodBUS().GetHistoryFoodsFromUsername(username);
            this.historyUsed = new HistoryUsedBUS().GetHistoryUsedsFromUsername(username);

            //Detail Account
            this.usernameLabel.Text = this.detailAccount.username.Trim();
            this.nameTextBox.Text = this.detailAccount.name.Trim();
            this.ageTextBox.Text = this.detailAccount.age.ToString().Trim();
            this.phoneTextBox.Text = this.detailAccount.phone.Trim();
            this.cmndTextBox.Text = this.detailAccount.cmnd.ToString().Trim();

            //Timer
            this.money.Text = string.Format("{0:n0}",this.timer.money_left);
            this.time.Text = this.ShowTimeLeft(this.timer.time_left);
            this.checkTimer.Tick += checkTimer_Tick;
            //this.checkTimer.Interval = 1000; //second
            this.checkTimer.Interval = 60000; // minute
            this.checkTimer.Start();
        }

        private void checkTimer_Tick(object sender, EventArgs e) {
            this.timer = new TimerBUS().GetTimerAccount(this.detailAccount.username);
            this.timer.time_left -= 1;
            this.timer.money_left -= 100;

            this.time.Text = this.ShowTimeLeft(this.timer.time_left);
            this.money.Text = string.Format("{0:n0}", this.timer.money_left);

            new TimerBUS().Update(this.timer, -100);

            if(this.timer.time_left <= 0) {
                exit(this, new EventArgs());
            }
        }

        private string ShowTimeLeft(int time_left) {
            int h = time_left / 60;
            int m = time_left % 60;
            string hStr = (h < 10) ? ("0" + h.ToString()) : h.ToString();
            string mStr = (m < 10) ? ("0" + m.ToString()) : m.ToString();
            return hStr + ":" + mStr;
        }

        private void saveButton_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.detailAccount.username = this.usernameLabel.Text;
                this.detailAccount.name = this.nameTextBox.Text;
                this.detailAccount.age = int.Parse(this.ageTextBox.Text);
                this.detailAccount.phone = this.phoneTextBox.Text;
                this.detailAccount.cmnd = int.Parse(this.cmndTextBox.Text);
                new DetailAccountBUS().Update(detailAccount);
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void clearButton_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.oldPassText.Text = "";
                this.newPassText.Text = "";
                this.rePassText.Text = "";
            }
        }

        private void okButton_MouseDown(object sender, MouseEventArgs e) {
            //try {
                if(e.Button == MouseButtons.Left) {
                    if(this.oldPassText.Text == "" || this.newPassText.Text == "" || this.rePassText.Text == "") throw new Exception("Nhập chỗ còn trống");
                    if(!new AccountBUS().IsLogin(this.detailAccount.username, this.oldPassText.Text)) throw new Exception("Mật khẩu cũ không đúng");
                    if(this.newPassText.Text != this.rePassText.Text) throw new Exception("Mật khẩu không khớp");
                    new AccountBUS().Update(new Account() {
                        username = this.detailAccount.username,
                        password = this.rePassText.Text,

                    });
                    MessageBox.Show("Đổi thành công");
                    this.oldPassText.Text = "";
                    this.newPassText.Text = "";
                    this.rePassText.Text = "";
                    this.informLabel.Text = "";
                }
            //}
            /*catch(Exception ex) {
                this.informLabel.Text = ex.Message;
            }*/
        }

        private void historyFoodLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                HistoryForm historyForm = new HistoryForm();
                historyForm.TitleLabel.Text = "Lịch sử gọi món";              
                historyForm.DataGridView.Columns[0].HeaderText = "Tên món";
                historyForm.DataGridView.Columns[1].HeaderText = "Thời gian";
                for(int i = 0; i < this.historyFood.Length; ++i) {
                    historyForm.DataGridView.Rows.Add(this.historyFood[i].food.name, this.historyFood[i].time);
                }
                historyForm.Show();
            }
        }

        private void historyFoodLabel_MouseEnter(object sender, EventArgs e) {
            historyFoodLabel.BackColor = Color.LightGray;
        }

        private void historyFoodLabel_MouseLeave(object sender, EventArgs e) {
            historyFoodLabel.BackColor = Color.FromName("Sliver");
        }

        private void historyUsedLabel_MouseEnter(object sender, EventArgs e) {
            historyUsedLabel.BackColor = Color.LightGray;
        }

        private void historyUsedLabel_MouseLeave(object sender, EventArgs e) {
            historyUsedLabel.BackColor = Color.FromName("Sliver");
        }

        private void historyUsedLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                HistoryForm historyForm = new HistoryForm();
                historyForm.TitleLabel.Text = "Lịch sử gọi món";
                historyForm.DataGridView.Columns[0].HeaderText = "Máy";
                historyForm.DataGridView.Columns[1].HeaderText = "Thời gian";
                for(int i = 0; i < this.historyUsed.Length; ++i) {
                    historyForm.DataGridView.Rows.Add(this.historyUsed[i].computerClient.number, this.historyUsed[i].time);
                }
                historyForm.Show();
            }
        }

        public void Stop() {
            this.checkTimer.Stop();
        }
    }
}
