using Domain.Aggregates.ShoppingRecords.Events;
using Domain.Entities;
using NUnit.Framework;
using System;

namespace Domain.Tests.Aggregates
{
    [TestFixture]
    public class RecordShoppingDomainEventTests
    {
        [Test]
        public void CreateEventTest()
        {
            var shop = new Shop();
            var shopRecordedEvent = new ShopRecordedEvent(shop);

            Assert.AreEqual(shop, shopRecordedEvent.Shop);
        }
    }

    [TestFixture]
    public class DateTimeRecordedEventTests
    {
        [Test]
        public void CreateEventTest()
        {
            var dateTimeRecordedEvent = new DateTimeRecordedEvent(DateTimeOffset.UtcNow);
        }
    }

    [TestFixture]
    public class TotalAmountRecordedEventTests
    {
        [Test]
        public void CreateEventTest()
        {
            var totalAmountCreatedEvent = new TotalAmountRecordedEvent(5.00m);
        }
    }
    
}
