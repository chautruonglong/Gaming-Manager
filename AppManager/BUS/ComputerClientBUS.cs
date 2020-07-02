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

        public ComputerClient[] GetComputerClients() {
            DataTable dt = new ComputerClientDAO().GetComputerClients();
            int count = dt.Rows.Count;
            ComputerClient[] computerClients = new ComputerClient[count];

            for(int i = 0; i < count; ++i) {
                computerClients[i] = new ComputerClient();
                computerClients[i].ipv4 = dt.Rows[i]["ipv4"].ToString();
                computerClients[i].number = int.Parse(dt.Rows[i]["number"].ToString());
            }

            //sort
            Array.Sort(computerClients, cmp);
           
            return computerClients;
        }

        private int cmp(ComputerClient a, ComputerClient b) {
            return a.number - b.number;
        }

        public void Insert(string ipv4) {
            ComputerClient computerClient = new ComputerClient() {
                ipv4 = ipv4,
                number = new ComputerClientDAO().Count + 1
            };
            new ComputerClientDAO().Insert(computerClient);
        }
    }

    public class ComputerClientConnection {
        private TcpListener listenerChat;
        private int portChat = 9999;

        private TcpListener listenerRemote;
        private int portRemote = 6666;

        public ComputerClientConnection() {
            string ip = GetIpAddress();
            IPAddress localIp = IPAddress.Parse(ip);

            listenerChat = new TcpListener(localIp, portChat);
            listenerRemote = new TcpListener(localIp, portRemote);

            listenerChat.Start();
            listenerRemote.Start();
        }

        public static string GetIpAddress() {
            string hostName = Dns.GetHostName();
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);
            foreach(IPAddress address in addresses) {
                if(address.AddressFamily == AddressFamily.InterNetwork) return address.ToString();
            }
            return null;
        }

        public TcpClient[] ListeningClientConnection() {
            TcpClient []tcpClient = new TcpClient[2];
            // tcpClient[0] chat
            // tcpClient[1] remote
            tcpClient[0] = listenerChat.AcceptTcpClient();
            tcpClient[1] = listenerRemote.AcceptTcpClient();
            return tcpClient;
        }

    }

    public class ComputerClientChat {
        private TcpClient tcpClientChat;
        private StreamWriter writer;
        private StreamReader reader;

        public ComputerClientChat(TcpClient tcpClient) {
            this.tcpClientChat = tcpClient;
            writer = new StreamWriter(tcpClientChat.GetStream());
            reader = new StreamReader(tcpClientChat.GetStream());
        }

        public void SendMessage(string message) {
            try {
                if(IsClientConnected) {
                    writer.WriteLine(message);
                    writer.Flush();
                }
            }
            catch(Exception e) { }
        }

        public string ReceiveMessage() {
            try {
                if(IsClientConnected) {
                    string message = reader.ReadLine();
                    return message;
                }
            }
            catch(Exception e) { }
            return null;
        }

        public bool IsClientConnected {
            get {
                IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();
                foreach (TcpConnectionInformation c in tcpConnections) {
                    TcpState stateOfConnection = c.State;
                    if (tcpClientChat != null && tcpClientChat.Connected && 
                        c.LocalEndPoint.Equals(tcpClientChat.Client.LocalEndPoint) && 
                        c.RemoteEndPoint.Equals(tcpClientChat.Client.RemoteEndPoint)) {
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

        public void Close() {
            reader.Close();
            writer.Close();
            tcpClientChat.Close();
        }
    }

    public class ComputerClientRemote {
        private TcpClient tcpClientRemote;
        private StreamWriter writer;

        public ComputerClientRemote(TcpClient tcpClient) {
            this.tcpClientRemote = tcpClient;
            writer = new StreamWriter(tcpClientRemote.GetStream());
        }

        public void ShutDownClient() {
            try {
                if(IsClientConnected) {
                    writer.WriteLine("/C shutdown -s -t 0");
                    writer.Flush();
                }
            }
            catch(Exception e) { }
        }

        public void ResetClient() {
            try {
                if(IsClientConnected) {
                    writer.WriteLine("/C shutdown -r -t 0");
                    writer.Flush();
                }
            }
            catch (Exception e) { }
        }

        public bool IsClientConnected {
            get {
                IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();
                foreach (TcpConnectionInformation c in tcpConnections) {
                    TcpState stateOfConnection = c.State;
                    if (tcpClientRemote != null && tcpClientRemote.Connected && 
                        c.LocalEndPoint.Equals(tcpClientRemote.Client.LocalEndPoint) && 
                        c.RemoteEndPoint.Equals(tcpClientRemote.Client.RemoteEndPoint)) {
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

        public void Close() {
            writer.Close();
            tcpClientRemote.Close();
        }
    }
}
