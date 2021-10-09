using Domain.Aggregates.ShoppingRecords;
using Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections;

namespace Domain.Tests.Aggregates
{
    [TestFixture]
    public class ShoppingRecordsAggregateTests
    {
        private ShoppingRecordsAggregate _aggregate;

        [SetUp]
        public void SetUp()
        {
            var person = new Person("John", "Smith");
            var builder = new ShoppingRecordBuilder();
            _aggregate = new ShoppingRecordsAggregate(person, builder);
        }

        [Test]
        public void AddNewRecord_Test()
        {
            _aggregate.AddNewRecord(shop:new Shop(), date: DateTimeOffset.UtcNow, amount:10m);

            CollectionAssert.IsNotEmpty(_aggregate.Records);
        }
    }
}
