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
            var shopRecordedEvent = new ShopRecordedEvent(shopId:1);
        }
    }

    public class ShopRecordedEvent : IDomainEvent
    {
        public ShopRecordedEvent(int shopId)
        {
            ShopId = shopId;
        }
        public int ShopId { get; }
    }

    [TestFixture]
    public class ShoppingAggregateTests
    {
        [Test]
        public void TestFluentAPI()
        {
            var shopping = new ShoppingRecordAggregate(new Person("John", "Smith"));
            var shop = 1;
            shopping.RecordShop(shop).RecordDateAndTime(DateTimeOffset.UtcNow).RecordTotalAmmountSpent(5.00m);

            Assert.AreEqual(shop, shopping.Shop.ShopId);
        }

        [Test]
        public void TestDomainEvents()
        {
            var shopping = new ShoppingRecordAggregate(new Person("John", "Smith"));
            shopping.RecordShop(1);
        }
    }
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
