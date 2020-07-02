using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS {
    public class ComputerClientBUS {
        public int GetNumberComputerFromIpv4(string ipv4) {
            DataTable dt = DBHelper.GetTable("SELECT [number] FROM [ComputerClient] WHERE [ipv4] = '" + ipv4 + "'");
            return int.Parse(dt.Rows[0][0].ToString());
        }

        public ComputerClient GetComputerClientFromIpv4(string ipv4) {
            DataTable dt = DBHelper.GetTable("SELECT * FROM [ComputerClient] WHERE [ipv4] = '" + ipv4 + "'");
            return new ComputerClient() {
                ipv4 = ipv4,
                number = int.Parse(dt.Rows[0]["number"].ToString())
            };
        }
    }

    public class ComputerClientConnection {
        TcpClient tcpClientChat;
        TcpClient tcpClientRemote;
       
        public ComputerClientChat computerClientChat { get; set; }
        public ComputerClientRemote computerClientRemote { get;set; }

        string ipServer = "172.20.10.13";
        int portChat = 9999;
        int portRemote = 6666;

        public ComputerClientConnection() {
            this.tcpClientChat = new TcpClient();
            this.tcpClientRemote = new TcpClient();
        }

        public bool IsConnected(TcpClient tcpClient) {
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();
            foreach (TcpConnectionInformation c in tcpConnections) {
                TcpState stateOfConnection = c.State;
                if (tcpClient != null && tcpClient.Connected &&
                    c.LocalEndPoint.Equals(tcpClient.Client.LocalEndPoint) &&
                    c.RemoteEndPoint.Equals(tcpClient.Client.RemoteEndPoint)) {
                    if (stateOfConnection == TcpState.Established) {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
            return false;
        }

        public void StartConnection() {
            new Thread(delegate () { 
                while(true) {
                    try {
                        if (this.computerClientChat == null || this.computerClientRemote == null || !this.computerClientChat.IsConnected || !this.computerClientRemote.IsConnected) {
                            this.tcpClientChat.Connect(this.ipServer, this.portChat);
                            this.tcpClientRemote.Connect(this.ipServer, this.portRemote);
                            this.computerClientChat = new ComputerClientChat(this.tcpClientChat);
                            this.computerClientRemote = new ComputerClientRemote(this.tcpClientRemote);
                        }
                    }
                    catch (Exception e) {
                        this.tcpClientChat = new TcpClient();
                        this.tcpClientRemote = new TcpClient();
                    }
                    Thread.Sleep(1000);
                }
            }) { 
                IsBackground = true 
            }.Start();
        }

        public void Close() {
            this.tcpClientChat.Close();
            this.tcpClientRemote.Close();
        }
    }

    public class ComputerClientChat {
        TcpClient tcpClientChat;
        StreamReader reader;
        StreamWriter writer;

        public ComputerClientChat(TcpClient tcpClientChat) {
            this.tcpClientChat = tcpClientChat;
            this.reader = new StreamReader(this.tcpClientChat.GetStream());
            this.writer = new StreamWriter(this.tcpClientChat.GetStream());
        }

        public bool IsConnected {
            get {
                IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();
                foreach (TcpConnectionInformation c in tcpConnections) {
                    TcpState stateOfConnection = c.State;
                    if (this.tcpClientChat != null && this.tcpClientChat.Connected &&
                        c.LocalEndPoint.Equals(this.tcpClientChat.Client.LocalEndPoint) &&
                        c.RemoteEndPoint.Equals(this.tcpClientChat.Client.RemoteEndPoint)) {
                        if (stateOfConnection == TcpState.Established) {
                            return true;
                        }
                        else {
                            return false;
                        }
                    }
                }
                return false;
            }
        }

        public void SendMessage(string message) {
            try {
                if(this.writer != null && this.IsConnected) {
                    this.writer.WriteLine(message);
                    this.writer.Flush();
                }
            }
            catch(Exception e) { }
        }

        public string ReceiveMessage() {
            try {
                if (this.reader != null && this.IsConnected) {
                    string message = this.reader.ReadLine();
                    return message;
                }
            }
            catch(Exception e) { }
            return null;
        }
    }

    public class ComputerClientRemote {
        TcpClient tcpClientRemote;
        StreamReader reader;

        public ComputerClientRemote(TcpClient tcpClientRemote) {
            this.tcpClientRemote = tcpClientRemote;
            this.reader = new StreamReader(this.tcpClientRemote.GetStream());
            this.ReceiveMessage();
        }

        public bool IsConnected {
            get {
                IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();
                foreach (TcpConnectionInformation c in tcpConnections) {
                    TcpState stateOfConnection = c.State;
                    if (this.tcpClientRemote != null && this.tcpClientRemote.Connected &&
                        c.LocalEndPoint.Equals(this.tcpClientRemote.Client.LocalEndPoint) &&
                        c.RemoteEndPoint.Equals(this.tcpClientRemote.Client.RemoteEndPoint)) {
                        if (stateOfConnection == TcpState.Established) {
                            return true;
                        }
                        else {
                            return false;
                        }
                    }
                }
                return false;
            }
        }

        public void ReceiveMessage() {
            new Thread(delegate () {
                while(true) {
                    try {
                        if(this.reader != null && this.IsConnected) {
                            string cmd = this.reader.ReadLine();
                            System.Diagnostics.Process.Start("Cmd.exe", cmd);
                        }
                    }
                    catch(Exception e) { }
                    Thread.Sleep(1000);
                }
            }) {
                IsBackground = true
            }.Start();
        }
    }
}
