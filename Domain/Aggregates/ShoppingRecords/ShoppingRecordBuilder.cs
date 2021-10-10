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
        private Queue _constructionQueue = new Queue();
      
        public ShoppingRecordBuilder()
        {}

        public IRecordDateAndTime RecordShop(Shop shop)
        {
            _constructionQueue.Enqueue(shop);
            return this;
        }

        public IRecordTotalAmount RecordDateAndTime(DateTimeOffset dateAndTime)
        {
            _constructionQueue.Enqueue(dateAndTime);
            return this;
        }

        public IBuildRecord RecordTotalAmmountSpent(decimal totalAmount)
        {
            _constructionQueue.Enqueue(totalAmount);   

            return this;           
        }

        public ShoppingRecord Build()
        {
            var shop = (Shop)_constructionQueue.Dequeue();
            var date= (DateTimeOffset)_constructionQueue.Dequeue();
            var amount = (decimal)_constructionQueue.Dequeue();

            return new ShoppingRecord(shop, date, amount);
        }
    }
}
