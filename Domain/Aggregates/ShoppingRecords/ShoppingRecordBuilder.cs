using System;
using System.Collections;
using System.Collections.Generic;
using Domain.Aggregates.ShoppingRecords.Events;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Aggregates.ShoppingRecords
{
    public interface IRecordShop
    {
        IRecordDateAndTime RecordShop(Shop shop);

    }
    public interface IRecordDateAndTime
    {
        IRecordTotalAmount RecordDateAndTime(DateTimeOffset dateAndTime);
    }
    public interface IRecordTotalAmount
    {
        IBuildRecord RecordTotalAmmountSpent(decimal totalAmount);
    }

    public interface IBuildRecord
    {
        ShoppingRecord Build();
    }
    
    public class ShoppingRecordBuilder : IRecordShop, IRecordDateAndTime, IRecordTotalAmount, IBuildRecord
    {
        private Queue<IDomainEvent> _eventQueue = new Queue<IDomainEvent>();
      
        public ShoppingRecordBuilder()
        {}

        public IRecordDateAndTime RecordShop(Shop shop)
        {
            _eventQueue.Enqueue(new ShopRecordedEvent(shop));
            return this;
        }

        public IRecordTotalAmount RecordDateAndTime(DateTimeOffset dateAndTime)
        {
            _eventQueue.Enqueue(new DateTimeRecordedEvent(dateAndTime));
            return this;
        }

        public IBuildRecord RecordTotalAmmountSpent(decimal totalAmount)
        {
            _eventQueue.Enqueue(new TotalAmountRecordedEvent(totalAmount));   

            return this;           
        }

        public ShoppingRecord Build()
        {
            var shopEvent = (ShopRecordedEvent)_eventQueue.Dequeue();
            var dateEvent = (DateTimeRecordedEvent)_eventQueue.Dequeue();
            var amountEvent = (TotalAmountRecordedEvent)_eventQueue.Dequeue();

            return new ShoppingRecord(shop: shopEvent.Shop, dateEvent.Date, amountEvent.Total);
        }
    }
}
