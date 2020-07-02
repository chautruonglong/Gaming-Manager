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
using System.Threading;

namespace GUI {
    public struct Message {
        public string content;
        public bool isSend;
    };

    public partial class ChatForm : UserControl {
        public ComputerClientConnection computerClientConnection { get; set; }
        int line = 1;

        public ChatForm() {
            InitializeComponent();
            this.CreateHandle();
            this.computerClientConnection = new ComputerClientConnection();
            try {
                this.computerClientConnection.StartConnection();
            }catch(Exception e) {
                MessageBox.Show(e.Message);
            }
            this.WaitingMessage();
        }

        public Queue<Message> messagesNotSowYet { get; set; } = new Queue<Message>();

        private void WaitingMessage() {
            new Thread(delegate () {
                while(true) {
                    if (this.computerClientConnection.computerClientChat != null && this.computerClientConnection.computerClientChat.IsConnected) {
                        string message = this.computerClientConnection.computerClientChat.ReceiveMessage();
                        if(this.Visible == false) {
                            this.messagesNotSowYet.Enqueue(new Message() {
                                content = message,
                                isSend = false
                            });
                            continue;
                        }
                        messagePanel.Invoke(new MethodInvoker(delegate () {
                            if(message != null) DisplayReveiveMessage(message);
                        }));
                    }
                }
            }) {
                IsBackground = true
            }.Start();
        }

        private void contentTextBox_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                if (this.contentTextBox.Text != "" && this.computerClientConnection.computerClientChat != null && this.computerClientConnection.computerClientChat.IsConnected) {
                    this.computerClientConnection.computerClientChat.SendMessage(contentTextBox.Text);
                    this.DisplaySendMessage(contentTextBox.Text);
                    this.contentTextBox.Text = "";
                }
            }
        }

        private void sendLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                if (this.contentTextBox.Text != "" && this.computerClientConnection.computerClientChat != null && this.computerClientConnection.computerClientRemote.IsConnected) {
                    this.computerClientConnection.computerClientChat.SendMessage(contentTextBox.Text);
                    this.DisplaySendMessage(contentTextBox.Text);
                    this.contentTextBox.Text = "";
                }
            }
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

        private void DisplayReveiveMessage(string message) {
            Label label = new Label();
            label.Text = message;
            label.BackColor = Color.LightGreen;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleRight;
            label.Font = new Font("Segoe UI", 10F);

            messagePanel.Controls.Add(label);
            messagePanel.ScrollControlIntoView(label);

            messagePanel.AutoScrollPosition = new Point(0, messagePanel.DisplayRectangle.Height);
            label.Location = new Point(messagePanel.Width - label.Width - 30, line);
            messagePanel.AutoScrollPosition = new Point(0, messagePanel.DisplayRectangle.Height);

            line += label.Height + 3;
            if (line >= messagePanel.Height) line = messagePanel.Height;
        }

        private void ChatForm_VisibleChanged(object sender, EventArgs e) {
            if(this.Visible == true) {
                while(this.messagesNotSowYet.Count > 0) {
                    this.messagePanel.Invoke(new MethodInvoker(delegate () {
                        Message message = this.messagesNotSowYet.Dequeue();
                        if(message.isSend) this.DisplaySendMessage(message.content);
                        else this.DisplayReveiveMessage(message.content);
                    }));
                }
            }
        }
    }
}
