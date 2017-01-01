using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using phonizer.Content;
using Phonizer.Models;

namespace Phonizer.Services
{
    public class LocalDbService
    {

        private string ConnectionString { get; }

        public LocalDbService(DbSettings dbSettings)
        {
            ConnectionString = $"Data Source={dbSettings.Address}; AttachDbFilename={dbSettings.Name}; " +
                               "Integrated Security=True; Connect Timeout=30";
        }

        public bool IsConnectionSuccess()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    return connection.Query<bool>(Queries.TestConnection).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Order>> GetOrdersByPhone(string phonePattern)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                return (await connection.QueryAsync<Order>(Queries.GetOrdersByPhoneLocal, new { phonePattern })
                    .ConfigureAwait(false)).ToList();
            }
        }

        public async Task SaveOrders(List<Order> orders)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                await connection.ExecuteAsync(Queries.SaveOrdersInLocal, orders)
                    .ConfigureAwait(false);
            }
        }
    }
}