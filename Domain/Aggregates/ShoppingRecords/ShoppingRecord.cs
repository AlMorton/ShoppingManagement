using System;
using Domain.Entities;

namespace Domain.Aggregates.ShoppingRecords
{
    public class ShoppingRecord
    {
        public ShoppingRecord(Shop shop, DateTimeOffset date, decimal amount)
        {
            Shop = shop;
            Date = date;
            Amount = amount;
        }

        public Shop Shop { get; }
        public DateTimeOffset Date { get; }
        public decimal Amount { get; }
    }
}
