using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI {
    class ComputerClientLabel : Label {
        private Image imageOn, imageOff;

        private ContextMenuStrip contextMenu;
        private ToolStripMenuItem shutdownItem;
        private ToolStripMenuItem resetItem;
        private ToolStripMenuItem chatItem;
        private ToolStripMenuItem historyUsedItem;
        private ToolStripMenuItem showIpItem;

        private ChatForm chatForm;

        private ComputerClientChat _computerClientChat;
        public ComputerClientChat computerClientChat {
            set {
                _computerClientChat = value;
                chatForm = new ChatForm(value);
                chatForm.TitleLabel.Text = "Máy số " + computerClient.number.ToString();
            }
            get => _computerClientChat;
        }

        private ComputerClientRemote _computerClientRemote;
        public ComputerClientRemote computerClientRemote {
            set => _computerClientRemote = value;
            get => _computerClientRemote;
        }

        public ComputerClient computerClient { get; set; }

        private bool _IsOnline;
        public bool IsOnline {
            set {
                _IsOnline = value;
                if (value == true) {
                    this.Image = imageOn;
                    shutdownItem.Enabled = true;
                    resetItem.Enabled = true;
                    chatItem.Enabled = true;
                }
                else {
                    this.Image = imageOff;
                    shutdownItem.Enabled = false;
                    resetItem.Enabled = false;
                    chatItem.Enabled = false;
                    if (chatForm != null) {
                        chatForm.Close();
                    }
                    if (computerClientChat != null) {
                        computerClientChat.Close();
                        computerClientChat = null;
                    }
                    if (computerClientRemote != null) {
                        computerClientRemote.Close();
                        computerClientRemote = null;
                    }
                }
            }
            get => _IsOnline;
        }

        public ComputerClientLabel(ComputerClient computerClient) {
            contextMenu = new ContextMenuStrip();
            shutdownItem = new ToolStripMenuItem();
            resetItem = new ToolStripMenuItem();
            chatItem = new ToolStripMenuItem();
            historyUsedItem = new ToolStripMenuItem();
            showIpItem = new ToolStripMenuItem();

            ComponentResourceManager resources = new ComponentResourceManager(typeof(Resource));

            imageOn = (Image)resources.GetObject("ClientOn.Image");
            imageOff = (Image)resources.GetObject("ClientOff.Image");

            shutdownItem.Text = "Tắt máy";
            shutdownItem.MouseDown += shutdownItem_MouseDown;

            resetItem.Text = "Khởi dộng lại";
            resetItem.MouseDown += resetItem_MouseDown;

            chatItem.Text = "Nhắn tin";
            chatItem.MouseDown += chatItem_MouseDown;

            historyUsedItem.Text = "Lịch sử đăng nhập";
            historyUsedItem.MouseDown += historyUsedItem_MouseDown;

            showIpItem.Text = "Xem IP";
            showIpItem.MouseDown += showIpItem_MouseDown;

            contextMenu.Items.AddRange(new ToolStripItem[] {
                shutdownItem,
                resetItem,
                chatItem,
                historyUsedItem,
                showIpItem
            });     

            this.computerClient = computerClient;
            this.AutoSize = false;
            this.Size = new Size(90, 100);
            this.MouseEnter += ClientLabel_MouseEnter;
            this.MouseLeave += ClientLabel_MouseLeave;
            this.MouseDown += ClientLabel_MouseDown;
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.TopCenter;
            this.Text = "Máy số " + computerClient.number.ToString();
            this.Image = imageOff;
            this.IsOnline = false;
        }

        private void ClientLabel_MouseEnter(object sender, EventArgs e) {
            this.BackColor = Color.LightGray;
        }

        private void ClientLabel_MouseLeave(object sender, EventArgs e) {
            this.BackColor = Color.FromName("ControlLight");
        }

        private void ClientLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                contextMenu.Show(this, 45, 50);
            }
        }

        private void shutdownItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                contextMenu.Hide();
                computerClientRemote.ShutDownClient();
            }
        }

        private void resetItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                contextMenu.Hide();
                computerClientRemote.ResetClient();
            }
        }

        private void chatItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                contextMenu.Hide();
                chatForm.Show();
            }
        }

        private void showIpItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                contextMenu.Hide();
                MessageBox.Show(computerClient.ipv4.Trim());        
            }
        }

        private void historyUsedItem_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                HistoryForm historyForm = new HistoryForm();
                historyForm.TitleLabel.Text = "Lịch sử đăng nhập";
                historyForm.DataGridView.Columns.Clear();
                historyForm.DataGridView.Columns.AddRange(new DataGridViewTextBoxColumn[] {
                    new DataGridViewTextBoxColumn() {
                        HeaderText = "Tài khoản",
                        ReadOnly = true,
                        Width = 140
                    },
                    new DataGridViewTextBoxColumn() {
                        HeaderText = "Thời gian",
                        ReadOnly = true,
                        Width = 140
                    }
                });

                HistoryUsed[] historyUseds = new HistoryUsedBUS().GetHistoryUsedsFromIpv4(computerClient.ipv4);
                for(int i = 0; i < historyUseds.Length; ++i) {
                    historyForm.DataGridView.Rows.Add(historyUseds[i].username, historyUseds[i].time);
                }

                historyForm.Show();
            }
        }
    }
}
