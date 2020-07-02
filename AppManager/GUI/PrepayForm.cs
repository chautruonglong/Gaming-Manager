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

namespace GUI {
    public partial class PrepayForm : Form {
        DTO.Timer timer;

        public PrepayForm(DTO.Timer timer) {
            this.timer = timer;
            InitializeComponent();

            moneyLeftTextBox.Text = timer.money_left.ToString();
            timeLeftTextBox.Text = timer.time_left.ToString();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void okButton_Click(object sender, EventArgs e) {
            try {
                float money = float.Parse(moneyTextBox.Text);
                new TimerBUS().InsertOrUpdate(timer, money);
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
