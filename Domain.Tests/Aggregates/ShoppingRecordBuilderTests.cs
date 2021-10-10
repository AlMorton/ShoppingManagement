using System;
using Domain.Aggregates.ShoppingRecords;
using Domain.Aggregates.ShoppingRecords.Events;
using Domain.Entities;
using NUnit.Framework;

namespace Domain.Tests.Aggregates
{

    [TestFixture]
    public class ShoppingRecordBuilderTests
    {
        [Test]
        public void TestFluentAPI()
        {
            var shopping = new ShoppingRecordBuilder();
            var shop = new Shop();
            var date = DateTimeOffset.UtcNow;
            var amount = 5.00m;
            shopping.RecordShop(shop)
                    .RecordDateAndTime(date)
                    .RecordTotalAmmountSpent(amount);

            var shoppingRecord = shopping.Build();

            Assert.IsNotNull(shoppingRecord);
            Assert.AreEqual(shop, shoppingRecord.Shop);
            Assert.AreEqual(date, shoppingRecord.Date);
            Assert.AreEqual(amount, shoppingRecord.Amount);            
        }
    }
}
