using System;

namespace Phonizer.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string OrderItems { get; set; }
        public string OrderSum { get; set; }
        public string Note { get; set; }
        public string PaymentMethod { get; set; }

        public override string ToString()
        {
            var rn = $".{Environment.NewLine}";
            var email = !string.IsNullOrEmpty(Email) ? $"Email: {Email}{rn}" : string.Empty;
            var note = !string.IsNullOrEmpty(Note) ? $"Примечание: {Note}." : string.Empty;
            return $"Заказ №{Id} от {Date.ToString("dd.MM.yyyy hh:mm:ss")}{rn}" +
                   $"От {Name} на сумму {OrderSum} руб. {PaymentMethod}{rn}" +
                   $"Содержимое: {OrderItems}{rn}" +
                   $"Адрес: {Street} {HouseNumber}{rn}" +
                   $"Телефон: {Phone}{rn}" +
                   $"{email}" +
                   $"{note}";
        }

        public object[] GetCells()
        {
            return new object[]
            {
                Id.ToString(),
                Date.ToString("dd.MM.yyyy hh:mm:ss"),
                Name,
                Phone,
                Email,
                Street,
                HouseNumber,
                OrderItems,
                OrderSum,
                Note,
                PaymentMethod
            };
        }
    }
}