using System;
using SQLite;

namespace RestaurantBilling.Core.Models
{
    [Table(nameof(Bill))]
    public class Bill
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(250)]
        public string CustomerEmail { get; set; }

        [NotNull]
        public double SubTotal { get; set; }

        [NotNull]
        public double Tip { get; set; }

        [NotNull]
        public double AmountPaid { get; set; }

        public Bill()
        {
            CustomerEmail = string.Empty;
            SubTotal = 0;
            Tip = 0;
            AmountPaid = 0;
        }

        public bool IsValid()
        {
            return (AmountPaid != 0 && !String.IsNullOrWhiteSpace(CustomerEmail));
        }
    }
}
