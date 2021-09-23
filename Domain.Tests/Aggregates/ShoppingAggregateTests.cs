using System;
using Domain.Entities;
using Domain.Interfaces;
using NUnit.Framework;

namespace Domain.Tests.Aggregates
{
    [TestFixture]
    public class RecordShoppingDomainEventTests
    {
        [Test]
        public void CreateEventTest()
        {
            var shopRecordedEvent = new ShopRecordedEvent();
        }
    }

    public class ShopRecordedEvent : IDomainEvent
    {
        public ShopRecordedEvent()
        {
        }
    }

    [TestFixture]
    public class ShoppingAggregateTests
    {
        [Test]
        public void TestFluentAPI()
        {
            var shopping = new ShoppingRecordAggregate(new Person("John", "Smith"));
            var shop = new Shop("MyBasket");
            shopping.RecordShop(shop).RecordDateAndTime(DateTimeOffset.UtcNow).RecordTotalAmmountSpent(5.00m);                        
        }

        [Test]
        public void TestDomainEvents()
        {
            var shopping = new ShoppingRecordAggregate(new Person("John", "Smith"));
            shopping.RecordShop(new Shop("Test"));
        }
    }
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
        void RecordTotalAmmountSpent(decimal totalAmount);
    }

    public class ShoppingRecordAggregate : IRecordShop, IRecordDateAndTime, IRecordTotalAmount
    {
        private Shop _shop;
        private Person _person;
        private DateTimeOffset _dateAndTime;
        private decimal _totalAmount;

        public ShoppingRecordAggregate(Person person)
        {
            _person = person;
        }

        public IRecordDateAndTime RecordShop(Shop shop)
        {
            _shop = shop;
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
