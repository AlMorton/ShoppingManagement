using System;
using System.Collections;
using System.Collections.Generic;
using Domain.Aggregates.ShoppingRecord.Events;
using Domain.Entities;
using Domain.Interfaces;

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
        private Queue<IDomainEvent> _eventQueue = new Queue<IDomainEvent>();
        private readonly Person _person;       

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
            _eventQueue.Enqueue(new DateTimeRecordedEvent(dateAndTime));
            return this;
        }

        public void RecordTotalAmmountSpent(decimal totalAmount)
        {
            _eventQueue.Enqueue(new TotalAmountRecordedEvent(totalAmount));            
        }

        public Queue<IDomainEvent> GetEvents()
        {
            return _eventQueue;
        }
    }
}
