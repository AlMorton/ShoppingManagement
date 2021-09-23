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
            var shopId = 1;
            var date = DateTimeOffset.UtcNow;
            var amount = 5.00m;
            shopping.RecordShop(shopId)
                    .RecordDateAndTime(date)
                    .RecordTotalAmmountSpent(amount);
            var events = shopping.GetEvents();

            var shopEvent = (ShopRecordedEvent)events.Dequeue();
            Assert.IsNotNull(shopEvent);
            Assert.AreEqual(shopId,shopEvent.ShopId);
            var dateRecorded = (DateTimeRecordedEvent)events.Dequeue();
            Assert.IsNotNull(dateRecorded);
            var totalAmount = (TotalAmountRecordedEvent)events.Dequeue();
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
