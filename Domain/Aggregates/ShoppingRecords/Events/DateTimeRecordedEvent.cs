using Domain.Interfaces;
using System;

namespace Domain.Aggregates.ShoppingRecords.Events
{
    public class DateTimeRecordedEvent : IDomainEvent
    {
        public DateTimeRecordedEvent(DateTimeOffset utcNow)
        {
            Date = utcNow;
        }

        public DateTimeOffset Date { get; }
    }

}
