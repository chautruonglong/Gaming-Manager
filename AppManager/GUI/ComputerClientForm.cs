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
using System.Net.Sockets;
using System.Net;

namespace GUI {
    public partial class ComputerClientForm : UserControl {
        ComputerClientLabel []computerClientLabels;

        public ComputerClientForm() {
            InitializeComponent();
            loadComputerClients();
            AcceptConnection();
            CheckingConnectionClients();
        }

        public void loadComputerClients() {
            ComputerClientBUS computerClientBUS = new ComputerClientBUS();
            ComputerClient[] computerClients = computerClientBUS.GetComputerClients();
            computerClientLabels = new ComputerClientLabel[computerClients.Length];
            int hgap = 60;
            int vgap = 20;
            int rows = computerClients.Length / 5 + 1;
            int count = 0;

            computersPanel.Controls.Clear();
            try {
                for (int i = 0; i < rows; ++i) {
                    for (int j = 0; j < 5; ++j) {
                        computerClientLabels[count] = new ComputerClientLabel(computerClients[count]);
                        computerClientLabels[count].Location = new Point(hgap + j * computerClientLabels[count].Size.Width, vgap + i * computerClientLabels[count].Size.Height);
                        computersPanel.Controls.Add(computerClientLabels[count]);
                        ++count;
                        hgap += 60;
                    }
                    hgap = 60;
                    vgap += 20;
                }
            }
            catch(Exception e) { }      
        }

        public void AcceptConnection() {
            ComputerClientConnection computerClientConnection = new ComputerClientConnection();
            new Thread(delegate () {
                while (true) {
                    try {
                        TcpClient[] tcpClient = computerClientConnection.ListeningClientConnection();
                        string ipv4 = ((IPEndPoint)tcpClient[0].Client.RemoteEndPoint).Address.ToString();
                        this.Invoke(new MethodInvoker(delegate () {
                            TurnOnComputerClient(ipv4, tcpClient);
                        }));
                    }
                    catch(Exception e) { }
                }
            }) {
                IsBackground = true
            }.Start();
        }

        public void TurnOnComputerClient(string ipv4, TcpClient []tcpClient) {
            // Old IPAddress 
            foreach (ComputerClientLabel clientLabel in computerClientLabels) {
                if(clientLabel.computerClient.ipv4.Trim() == ipv4) {
                    clientLabel.computerClientChat = new ComputerClientChat(tcpClient[0]);
                    clientLabel.computerClientRemote = new ComputerClientRemote(tcpClient[1]);
                    clientLabel.IsOnline = true;
                    return;
                }
            }

            // New IPAddress 
            new ComputerClientBUS().Insert(ipv4);
            loadComputerClients();
            TurnOnComputerClient(ipv4, tcpClient);
        }

        public void CheckingConnectionClients() {
            new Thread(delegate () {
                while(true) {
                    foreach (ComputerClientLabel clientLabel in computerClientLabels) {
                        if (clientLabel != null && clientLabel.computerClientChat != null) {
                            if (!clientLabel.computerClientChat.IsClientConnected) {
                                this.Invoke(new MethodInvoker(delegate () {
                                    clientLabel.IsOnline = false;
                                }));
                            }
                        }
                    }
                }
            }) { 
                IsBackground = true
            }.Start();
        }

        private void showIpv4Label_MouseEnter(object sender, EventArgs e) {
            showIpv4Label.BackColor = Color.DarkGray;
        }

        private void showIpv4Label_MouseLeave(object sender, EventArgs e) {
            showIpv4Label.BackColor = Color.FromName("Control");
        }

        private void showIpv4Label_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                MessageBox.Show(ComputerClientConnection.GetIpAddress());
            }
        }
    }
}
