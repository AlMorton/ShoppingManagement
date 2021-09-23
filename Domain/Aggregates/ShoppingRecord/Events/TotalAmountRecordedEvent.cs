using Domain.Interfaces;

namespace Domain.Aggregates.ShoppingRecord.Events
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
