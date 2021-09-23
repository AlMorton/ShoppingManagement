using System;
using Domain.Aggregates.ShoppingRecord;
using Domain.Aggregates.ShoppingRecord.Events;
using Domain.Entities;
using NUnit.Framework;

namespace Domain.Tests.Aggregates
{

    [TestFixture]
    public class ShoppingAggregateTests
    {
        [Test]
        public void TestFluentAPI()
        {
            var shopping = new ShoppingRecordAggregate(new Person("John", "Smith"));
            var shop = 1;
            var date = DateTimeOffset.UtcNow;
            var amount = 5.00m;
            shopping.RecordShop(shop)
                    .RecordDateAndTime(date)
                    .RecordTotalAmmountSpent(amount);
            var events = shopping.Save();

            var shopEvent = (ShopRecordedEvent)events.Dequeue();
            Assert.IsNotNull(shopEvent);
            var dateRecorded = (DateTimeOffset)events.Dequeue();
            Assert.IsNotNull(dateRecorded);
            var totalAmount = (decimal)events.Dequeue();
            Assert.IsNotNull(totalAmount);
        }

        [Test]
        public void TestDomainEvents()
        {
            var shopping = new ShoppingRecordAggregate(new Person("John", "Smith"));
            shopping.RecordShop(1);
        }
    }
    
}
