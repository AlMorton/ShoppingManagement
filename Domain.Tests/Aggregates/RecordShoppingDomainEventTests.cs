using Domain.Aggregates.ShoppingRecord.Events;
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
            var shopId = 1;
            var shopRecordedEvent = new ShopRecordedEvent(shopId);

            Assert.AreEqual(shopId, shopRecordedEvent.ShopId);
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
