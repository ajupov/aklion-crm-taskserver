using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using phonizer.Content;
using Phonizer.Content;
using Phonizer.Models;

namespace Phonizer.Services
{
    public class WoCommerceDbService
    {
        public WoCommerceDbService(DbSettings dbSettings)
        {
            ConnectionString = $"Server={dbSettings.Address}; database={dbSettings.Name}; " +
                               $"UID={dbSettings.Login}; password={dbSettings.Password}";
        }

        private string ConnectionString { get; }

        public bool IsConnectionSuccess()
        {
            try
            {
                using (var connection = new MySqlConnection(ConnectionString))
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
            using (var connection = new MySqlConnection(ConnectionString))
            {
                return (await connection.QueryAsync<Order>(Queries.GetOrdersByPhoneWc, new { phonePattern })
                    .ConfigureAwait(false)).ToList();
            }
        }

        public async Task<List<Order>> GetAllOrders(DateTime startDate, DateTime endDate)
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                return (await connection.QueryAsync<Order>(Queries.GetAllOrders, new { startDate, endDate })
                    .ConfigureAwait(false)).ToList();
            }
        }

        public async Task<int> GetMaxOrderId()
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                return (await connection.QueryAsync<int>(Queries.GetMaxOrderId, new { id = Static.Context.CurrentMaxId })
                    .ConfigureAwait(false)).FirstOrDefault();
            }
        }

        public async Task<int> GetNextOrderIdAsync()
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                return (await connection.QueryAsync<int>(Queries.GetNextOrderId, new { id = Static.Context.CurrentMaxId })
                    .ConfigureAwait(false)).FirstOrDefault();
            }

            //var orderId = 0;

            //using (var mySqlConnection = new MySqlConnection(ConnectionString))
            //{
            //    mySqlConnection.Open();

            //    var command = new MySqlCommand(Queries.GetNextOrderId, mySqlConnection);
            //    command.Parameters.Add("@id", MySqlDbType.Int32);
            //    command.Parameters["@id"].Value = Static.Context.CurrentMaxId;

            //    var reader = await command.ExecuteReaderAsync().ConfigureAwait(false);
            //    while (reader.Read())
            //    {
            //        orderId = Convert.ToInt32(reader.GetString(0));
            //    }

            //    mySqlConnection.Close();
            //}

            //return orderId;
        }

        public async Task<Order> GetOrderByIdAsync()
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                return (await connection.QueryAsync<Order>(Queries.GetOrderById, new { id = Static.Context.CurrentMaxId })
                    .ConfigureAwait(false)).FirstOrDefault();
            }

            //var order = new Order();

            //using (var mySqlConnection = new MySqlConnection(ConnectionString))
            //{

            //    mySqlConnection.Open();

            //    var command = new MySqlCommand(Resources.GetOrderById, mySqlConnection);
            //    command.Parameters.Add("@id", MySqlDbType.Int32);
            //    command.Parameters["@id"].Value = id;

            //    var reader = await command.ExecuteReaderAsync().ConfigureAwait(false);
            //    while (reader.Read())
            //    {
            //        order.Date = DateTime.Parse(reader.GetString(0));
            //        order.Name = reader.GetString(1);
            //        order.Email = reader.GetString(2);
            //        order.Phone = reader.GetString(3);
            //        order.Street = reader.GetString(4);
            //        order.HouseNumber = reader.GetString(5);
            //        order.OrderItems = reader.GetString(6);   
            //        order.OrderSum = decimal.Parse(reader.GetString(7).Replace(".", ","));   
            //    }

            //    mySqlConnection.Close();
            //}

            //return order;
        }
    }
}