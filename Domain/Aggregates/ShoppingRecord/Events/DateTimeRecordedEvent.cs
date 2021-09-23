using Domain.Interfaces;
using System;

namespace Domain.Aggregates.ShoppingRecord.Events
{
    public class DateTimeRecordedEvent : IDomainEvent
    {
        public DateTimeRecordedEvent(DateTimeOffset utcNow)
        {
            UtcNow = utcNow;
        }

        public DateTimeOffset UtcNow { get; }
    }

}
