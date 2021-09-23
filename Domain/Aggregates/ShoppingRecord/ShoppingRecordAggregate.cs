using System;
using System.Collections;
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
        private Queue _eventQueue = new Queue();
        public Person _person;       

        public ShoppingRecordAggregate(Person person)
        {
            _person = person;
        }

        public IRecordDateAndTime RecordShop(int shopId)
        {
            _eventQueue.Enqueue(new ShopRecordedEvent(shopId));
            return this;
        }

        public IRecordTotalAmount RecordDateAndTime(DateTimeOffset dateAndTime)
        {
            _eventQueue.Enqueue(dateAndTime);
            return this;
        }

        public void RecordTotalAmmountSpent(decimal totalAmount)
        {
            _eventQueue.Enqueue(totalAmount);            
        }

        public Queue Save()
        {
            return _eventQueue;
        }
    }
}
