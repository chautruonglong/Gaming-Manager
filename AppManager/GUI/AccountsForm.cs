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
    public partial class AccountsForm : UserControl {
        DataTable dt;

        ContextMenuStrip contextMenuStrip;
        ToolStripMenuItem prepayItem;
        ToolStripMenuItem passwordItem;
        ToolStripMenuItem historyFoodItem;
        ToolStripMenuItem historyUsedItem;
        ToolStripMenuItem deleteItem;

        public AccountsForm() {
            InitializeComponent();

            dt = new DataTable("Account");
            contextMenuStrip = new ContextMenuStrip();
            prepayItem = new ToolStripMenuItem();
            passwordItem = new ToolStripMenuItem();
            historyFoodItem = new ToolStripMenuItem();
            historyUsedItem = new ToolStripMenuItem();
            deleteItem = new ToolStripMenuItem();

            // DataGridView
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn("Tài khoản") {
                    ReadOnly = true
                },
                new DataColumn("Tiền (đồng)") {
                    ReadOnly = true
                },
                new DataColumn("Thời gian (phút)") {
                    ReadOnly = true
                },
                new DataColumn("Tên") {
                    ReadOnly = true
                },
                new DataColumn("Số điện thoại") {
                    ReadOnly = true
                },
                new DataColumn("Tuổi") {
                    ReadOnly = true
                },
                new DataColumn("CMND") {
                    ReadOnly = true
                }
            });
            
            dataGridView.DataSource = dt;
            dataGridView.Columns["Tài khoản"].Width = 130;
            dataGridView.Columns["Tên"].Width = 140;


            //ContextMenuStrip
            prepayItem.Text = "Nạp tiền";
            prepayItem.MouseDown += prepayItem_MouseDown;

            passwordItem.Text = "Đổi mật khẩu";
            passwordItem.MouseDown += passwordItem_MouseDown;

            historyFoodItem.Text = "Lịch sử gọi món";
            historyFoodItem.MouseDown += historyFoodItem_MouseDown;

            historyUsedItem.Text = "Lịch sử đăng nhập";
            historyUsedItem.MouseDown += historyUsedItem_MouseDown;

            deleteItem.Text = "Xóa tài khoản";
            deleteItem.MouseDown += deleteItem_MouseDown;

            contextMenuStrip.Items.AddRange(new ToolStripItem[] {
                prepayItem,
                passwordItem,
                historyFoodItem,
                historyUsedItem,
                deleteItem
            });

            loadClientAccounts();
        }

        public void loadClientAccounts() {
            dt.Rows.Clear();
            AccountBUS accountBUS = new AccountBUS();
            DetailAccountBUS detailAccountBUS = new DetailAccountBUS();
            TimerBUS timerBUS = new TimerBUS();

            Account[] accounts = accountBUS.GetListClientAccounts();
            int count = accounts.Length;
            for (int i = 0; i < count; ++i) {
                DetailAccount detail = detailAccountBUS.GetDetailAccount(accounts[i].username);
                DTO.Timer timer = timerBUS.GetTimerAccount(accounts[i].username);
                dt.Rows.Add(accounts[i].username, timer.money_left, timer.time_left, detail.name, detail.phone, detail.age, detail.cmnd);
            }
        }

        private void createLabel_MouseEnter(object sender, EventArgs e) {
            createLabel.BackColor = Color.LightGray;
        }

        private void createLabel_MouseLeave(object sender, EventArgs e) {
            createLabel.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void createLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                new CreateForm(this).Visible = true;
            }
        }

        private void reloadLabel_MouseEnter(object sender, EventArgs e) {
            reloadLabel.BackColor = Color.LightGray;
        }

        private void reloadLabel_MouseLeave(object sender, EventArgs e) {
            reloadLabel.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void reloadLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.loadClientAccounts();
            }
        }

        private void findTextBox_TextChanged(object sender, EventArgs e) {
            dt.DefaultView.RowFilter = string.Format("[Tài khoản] like '%{0}%'", findTextBox.Text);
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                int row = e.RowIndex;
                int col = e.ColumnIndex;
                if (row > -1 && col > -1) {
                    DataGridViewCell c = (sender as DataGridView)[col, row];
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                    contextMenuStrip.Show(new Point(MousePosition.X, MousePosition.Y));
                }
            }
        }

        private void prepayItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                string username = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["Tài khoản"].Value.ToString();
                string timer_id = new TimerBUS().GetTimerIdFromUsername(username);
                float money_left = float.Parse(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["Tiền (đồng)"].Value.ToString());
                int time_left = int.Parse(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["Thời gian (phút)"].Value.ToString());

                DTO.Timer timer = new DTO.Timer() {
                    timer_id = timer_id,
                    time_left = time_left,
                    money_left = money_left,
                    username = username
                };

                new PrepayForm(timer).ShowDialog(this);
                loadClientAccounts();
            }
        }

        private void passwordItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                string username = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["Tài khoản"].Value.ToString();
                new PasswordForm(username).ShowDialog(this);
            }
        }

        private void historyFoodItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                // Tao Form
                HistoryForm historyForm = new HistoryForm();
                historyForm.DataGridView.Columns.Clear();
                historyForm.DataGridView.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() {
                    Name = "Tên món",
                    ReadOnly = true,
                    Width = 140
                },
                new DataGridViewTextBoxColumn() {
                    Name = "Thời gian",
                    ReadOnly = true,
                    Width = 140
                }
            });

                // Lay du lieu
                string username = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["Tài khoản"].Value.ToString();
                HistoryFood[] historyFoods = new HistoryFoodBUS().GetHistoryFoodsFromUsername(username);
                FoodBUS foodBUS = new FoodBUS();

                for (int i = 0; i < historyFoods.Length; ++i) {
                    string name = foodBUS.GetNameFoodFromFoodId(historyFoods[i].food_id);
                    historyForm.DataGridView.Rows.Add(name, historyFoods[i].time);
                }

                historyForm.Show();
            }
        }

        private void historyUsedItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                // Tao Form
                HistoryForm historyForm = new HistoryForm();
                historyForm.TitleLabel.Text = "Lịch đăng nhập";
                historyForm.DataGridView.Columns.Clear();
                historyForm.DataGridView.Columns.AddRange(new DataGridViewColumn[] {
                new DataGridViewTextBoxColumn() {
                    Name = "Số máy",
                    ReadOnly = true,
                    Width = 140
                },
                new DataGridViewTextBoxColumn() {
                    Name = "Thời gian",
                    ReadOnly = true,
                    Width = 140
                }
            });

                // Lay du lieu
                string username = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["Tài khoản"].Value.ToString();
                HistoryUsed[] historyUseds = new HistoryUsedBUS().GetHistoryUsedsFromUsername(username);
                ComputerClientBUS computerBUS = new ComputerClientBUS();

                for (int i = 0; i < historyUseds.Length; ++i) {
                    int number = computerBUS.GetNumberComputerFromIpv4(historyUseds[i].ipv4);
                    historyForm.DataGridView.Rows.Add(number, historyUseds[i].time);
                }

                historyForm.Show();
            }
        }

        private void deleteItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                string username = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells["Tài khoản"].Value.ToString();
                new AccountBUS().DeleteClient(username);
                loadClientAccounts();
            }
        }
    }
}
