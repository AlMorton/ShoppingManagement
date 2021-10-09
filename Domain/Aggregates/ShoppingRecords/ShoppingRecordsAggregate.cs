using Domain.Aggregates.ShoppingRecords;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Aggregates.ShoppingRecords
{
    public class ShoppingRecordsAggregate
    {
        private readonly Person _person;
        private readonly ShoppingRecordBuilder _shoppingRecordBuilder;
        private readonly List<ShoppingRecord> _records;

        public ShoppingRecordsAggregate(Person person, ShoppingRecordBuilder shoppingRecordBuilder)
        {
            _person = person;
            _shoppingRecordBuilder = shoppingRecordBuilder;
            _records = new List<ShoppingRecord>();
        }

        public IReadOnlyCollection<ShoppingRecord> Records { get { return _records; } }

        public void AddNewRecord(Shop shop, DateTimeOffset date, decimal amount)
        {
            var record = _shoppingRecordBuilder.RecordShop(shop)
                                  .RecordDateAndTime(date)
                                  .RecordTotalAmmountSpent(amount)
                                  .Build();

            _records.Add(record);
        }
    }
}
