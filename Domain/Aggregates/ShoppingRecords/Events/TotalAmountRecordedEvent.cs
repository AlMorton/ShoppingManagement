using Domain.Interfaces;

namespace Domain.Aggregates.ShoppingRecords.Events
{
    public class TotalAmountRecordedEvent : IDomainEvent
    {
        public TotalAmountRecordedEvent(decimal total)
        {
            Total = total;
        }

        public decimal Total { get; }
    }

}
