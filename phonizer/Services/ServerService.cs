using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Phonizer.Content;

namespace Phonizer.Services
{
    public class ServerService
    {
        public string Ip { get; set; }

        public int Port { get; set; }

        public TcpListener Listener { get; set; }

        public bool OnlyLocal { get; set; }

        public ServerService(string ip, bool onlyLocal)
        {
            Ip = ip;
            Port = Convert.ToInt32(Configs.PortNumber);
            OnlyLocal = onlyLocal;
        }

        private void WaitForClientConnect()
        {
            Listener.BeginAcceptTcpClient(OnClientConnect, new object());
        }

        private void OnClientConnect(IAsyncResult asyncResult)
        {
            try
            {
                var client = Listener.EndAcceptTcpClient(asyncResult);
                var clientRequest = new ClientService(client, OnlyLocal);
                clientRequest.StartClient();
                WaitForClientConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void StartServer()
        {
            var ip = IPAddress.Parse(Ip);
            var endPoint = new IPEndPoint(ip, Port);

            Listener = new TcpListener(endPoint);
            Listener.Start();
            WaitForClientConnect();
        }
    }
}