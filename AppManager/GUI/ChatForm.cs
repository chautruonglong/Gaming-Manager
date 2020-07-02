using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI {
    public partial class ChatForm : Form {
        private int dx;
        private int dy;
        private bool IsDown;
        private int line = 0;

        private ComputerClientChat computerClientChat;
        private Thread threadReceiveMessage;

        public ChatForm(ComputerClientChat computerClientChat) {
            InitializeComponent();

            this.computerClientChat = computerClientChat;
            this.CreateHandle();

            threadReceiveMessage = new Thread(new ThreadStart(ListeningMessage));
            threadReceiveMessage.IsBackground = true;
            threadReceiveMessage.Start();
        }

        public void DisplayReceiveMessage(string message) {
            Label label = new Label();
            label.Text = message;
            label.BackColor = Color.LightGreen;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleRight;
            label.Font = new Font("Segoe UI", 10F);

            messagePanel.Controls.Add(label);
            messagePanel.ScrollControlIntoView(label);

            messagePanel.AutoScrollPosition = new Point(0, messagePanel.DisplayRectangle.Height);
            label.Location = new Point(messagePanel.Width - label.Width - 25, line);
            messagePanel.AutoScrollPosition = new Point(0, messagePanel.DisplayRectangle.Height);

            line += label.Height + 3;
            if(line >= messagePanel.Height) line = messagePanel.Height;
        }

        public void DisplaySendMessage(string message) {
            Label label = new Label();
            label.Text = message;
            label.BackColor = Color.LightGray;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("Segoe UI", 10F);

            messagePanel.Controls.Add(label);
            messagePanel.ScrollControlIntoView(label);

            messagePanel.AutoScrollPosition = new Point(0, messagePanel.DisplayRectangle.Height);
            label.Location = new Point(2, line);
            messagePanel.AutoScrollPosition = new Point(0, messagePanel.DisplayRectangle.Height);

            line += label.Height + 3;
            if (line >= messagePanel.Height) line = messagePanel.Height;
        }

        private void ListeningMessage() {
            while(true) {
                try {
                    if(computerClientChat != null && computerClientChat.IsClientConnected) {
                        string message = computerClientChat.ReceiveMessage();
                        messagePanel.BeginInvoke(new MethodInvoker(delegate () {
                            if(this.Visible == false) this.Show();
                            DisplayReceiveMessage(message);
                        }));
                    }
                }
                catch(Exception e) { }
            }      
        }

        private void sendLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                if(contentTextBox.Text != "") {
                    computerClientChat.SendMessage(contentTextBox.Text);
                    DisplaySendMessage(contentTextBox.Text);
                    contentTextBox.Text = "";
                }
            }
        }

        private void contentTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                if (contentTextBox.Text != "") {
                    computerClientChat.SendMessage(contentTextBox.Text);
                    DisplaySendMessage(contentTextBox.Text);
                    contentTextBox.Text = "";
                }
            }
        }

        // Event
        private void minimizeLabel_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(63, 63, 65);
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e) {
            closeLabel.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void sendLabel_MouseEnter(object sender, EventArgs e) {
            sendLabel.BackColor = Color.LightGray;
        }

        private void sendLabel_MouseLeave(object sender, EventArgs e) {
            sendLabel.BackColor = Color.FromName("ActiveBorder");
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

        private void closeLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.Hide();
            }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e) {
            threadReceiveMessage.Abort();
        }

        public Label TitleLabel {
            get => titleLabel;
            set => titleLabel = value;
        }
    }
}
