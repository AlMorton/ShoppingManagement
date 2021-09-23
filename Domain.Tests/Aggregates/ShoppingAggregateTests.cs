using System;
using Domain.Aggregates.ShoppingRecord;
using Domain.Aggregates.ShoppingRecord.Events;
using Domain.Entities;
using NUnit.Framework;

namespace Domain.Tests.Aggregates
{
    [TestFixture]
    public class RecordShoppingDomainEventTests
    {
        [Test]
        public void CreateEventTest()
        {
            var shopId = 1;
            var shopRecordedEvent = new ShopRecordedEvent(shopId);

            Assert.AreEqual(shopId, shopRecordedEvent.ShopId);
        }
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
    
}
