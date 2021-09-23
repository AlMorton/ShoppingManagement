using Domain.Interfaces;

namespace Domain.Aggregates.ShoppingRecord.Events
{
    public class ShopRecordedEvent : IDomainEvent
    {
        public ShopRecordedEvent(int shopId)
        {
            ShopId = shopId;
        }
        public int ShopId { get; }
    }
}
