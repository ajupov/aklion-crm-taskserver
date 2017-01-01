using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Phonizer.Models;

namespace Phonizer.Helpers
{
    public static class Network
    {
        public static List<ComboBoxItem> GetNetworkInterfaces()
        {
            var items = new List<ComboBoxItem>();

            foreach (var adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                var properties = adapter.GetIPProperties();

                foreach (var property in properties.UnicastAddresses)
                {
                    if ((adapter.OperationalStatus == OperationalStatus.Up)
                        && (property.Address.AddressFamily == AddressFamily.InterNetwork))
                    {
                        var item = new ComboBoxItem
                        {
                            Text = adapter.Description + " - " + property.Address,
                            Value = property.Address.ToString()
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
    }
}