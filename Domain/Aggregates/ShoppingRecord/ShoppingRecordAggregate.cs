using System;
using Domain.Aggregates.ShoppingRecord.Events;
using Domain.Entities;

namespace Domain.Aggregates.ShoppingRecord
{
    public interface IRecordShop
    {
        IRecordDateAndTime RecordShop(int shop);

    }
    public interface IRecordDateAndTime
    {
        IRecordTotalAmount RecordDateAndTime(DateTimeOffset dateAndTime);
    }
    public interface IRecordTotalAmount
    {
        void RecordTotalAmmountSpent(decimal totalAmount);
    }
    public class ShoppingRecordAggregate : IRecordShop, IRecordDateAndTime, IRecordTotalAmount
    {
        public ShopRecordedEvent Shop { get; private set; }
        private Person _person;
        private DateTimeOffset _dateAndTime;
        private decimal _totalAmount;

        public ShoppingRecordAggregate(Person person)
        {
            _person = person;
        }

        public IRecordDateAndTime RecordShop(int shop)
        {
            Shop = new ShopRecordedEvent(shop);
            return this;
        }

        public IRecordTotalAmount RecordDateAndTime(DateTimeOffset dateAndTime)
        {
            _dateAndTime = dateAndTime;
            return this;
        }

        public void RecordTotalAmmountSpent(decimal totalAmount)
        {
            _totalAmount = totalAmount;
        }
    }
}
