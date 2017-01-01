using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Phonizer.Enums;
using Phonizer.Helpers;

namespace Phonizer.Services
{
    public class ClientService
    {
        public ClientService(TcpClient client, bool onlyLocal)
        {
            Client = client;
            OnlyLocal = onlyLocal;
            LocalDbService = new LocalDbService(SettingsService.LoaLocalDbSettings());
            if (!onlyLocal)
            {
                WoCommerceDbService = new WoCommerceDbService(SettingsService.LoadWoCommerceDbSettings());
            }
        }

        public TcpClient Client { get; set; }

        public NetworkStream Stream { get; set; }

        public WoCommerceDbService WoCommerceDbService { get; set; }

        public LocalDbService LocalDbService { get; set; }

        public bool OnlyLocal { get; }

        public void StartClient()
        {
            Stream = Client.GetStream();
            WaitForRequest();
        }

        public void WaitForRequest()
        {
            try
            {
                var buffer = new byte[Client.ReceiveBufferSize];
                Stream.BeginRead(buffer, 0, buffer.Length, ReadCallback, buffer);
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
                Client.Close();
            }
        }

        private void ReadCallback(IAsyncResult result)
        {
            var networkStream = Client.GetStream();

            try
            {
                var read = networkStream.EndRead(result);

                if (read == 0)
                {
                    Stream.Close();
                    Client.Close();
                    return;
                }

                var data = result.AsyncState as byte[];
                ProcessRequest(data);
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }

            WaitForRequest();
        }

        private async void ProcessRequest(byte[] data)
        {
            try
            {
                var phone = Encoding.Default.GetString(data);
                await MyBusinessService.FindByPhone(LocalDbService, WoCommerceDbService, OnlyLocal, phone).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Toast.AlertError(ex.Message);
            }
        }
    }
}