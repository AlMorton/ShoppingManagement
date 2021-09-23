using Domain.Aggregates.ShoppingRecord.Events;
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
    
}
