using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phonizer.Enums;
using Phonizer.Helpers;
using Phonizer.Models;
using Phonizer.Static;

namespace Phonizer.Services
{
    public static class MyBusinessService
    {
        public static async Task FindByPhone(LocalDbService localDbService, WoCommerceDbService woCommerceDbService, bool onlyLocal, string phone)
        {
            var phonePattern = Pattern.FormatPhone(phone);

            var ordersFromLocalDb = await localDbService.GetOrdersByPhone(phonePattern).ConfigureAwait(false);
            string text;
            string names;

            if (!onlyLocal)
            {
                var ordersFromWcBb = await woCommerceDbService.GetOrdersByPhone(phonePattern);
                //var excepted = ordersFromWcBb.Except(ordersFromLocalDb).ToList();
                //await localDbService.SaveOrders(excepted).ConfigureAwait(false);
                text = string.Join(Environment.NewLine + Environment.NewLine, ordersFromWcBb);
                names = string.Join(", ", ordersFromWcBb.Select(o => o.Name));
            }
            else
            {
                text = string.Join(Environment.NewLine + Environment.NewLine, ordersFromLocalDb);
                names = string.Join(", ", ordersFromLocalDb.Select(o => o.Name));
            }

            if (string.IsNullOrEmpty(text))
            {
                text = $"{phonePattern} - не найдено";
                names = string.Empty;
            }

            Context.LoginForm.Invoke((MethodInvoker) (() =>
            {
                Context.CallsDataGridView.Rows.Add(DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss"), phonePattern, names);
            }));

            SoundService.Play();
            Toast.AlertInfo(EventType.SearchByPhone, text);
        }

        public static async Task GetOrderFromSite(LocalDbService localDbService, WoCommerceDbService woCommerceDbService, DataGridView dataGridView)
        {
            //var or = new Order
            //{
            //    Id = 2,
            //    Date = DateTime.Now,
            //    Email = "ajupov@moedelo.org",
            //    Name = "Усман",
            //    Phone = "+79374453807",
            //    Street = "Советская, 64",
            //    HouseNumber = "кв. 1",
            //    OrderItems = "Борщ",
            //    OrderSum = "52",
            //    PaymentMethod = "Наличка",
            //    Note = ""
            //};
            //dataGridView.Rows.Add(or.GetCells());

            var nextId = await woCommerceDbService.GetNextOrderIdAsync().ConfigureAwait(false);

            if (Static.Context.CurrentMaxId < nextId)
            {
                Static.Context.CurrentMaxId = nextId;
                var order = await woCommerceDbService.GetOrderByIdAsync().ConfigureAwait(false);
                await localDbService.SaveOrders(new List<Order> { order }).ConfigureAwait(false);
                dataGridView.Rows.Add(order.GetCells());
            
            Toast.AlertInfo(EventType.NewOrder, order.Name);
            }
        }

        public static async Task Synchronization(LocalDbService localDbService, WoCommerceDbService woCommerceDbService, DateTime startDate, DateTime endDate)
        {
            var ordersFromWcBb = await woCommerceDbService.GetAllOrders(startDate, endDate).ConfigureAwait(false);
            await localDbService.SaveOrders(ordersFromWcBb).ConfigureAwait(false);
        }
    }
}