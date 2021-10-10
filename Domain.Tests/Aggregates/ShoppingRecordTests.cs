using System;
using Domain.Aggregates.ShoppingRecords;
using Domain.Entities;
using NUnit.Framework;

namespace Domain.Tests.Aggregates
{
    [TestFixture]
    public class ShoppingRecordTests
    {
        [Test]
        public void CTOR_Test()
        {
            var shoppingRecord = new ShoppingRecord(shop: new Shop(), date: DateTimeOffset.UtcNow, amount:10m);
        }
    }
}
