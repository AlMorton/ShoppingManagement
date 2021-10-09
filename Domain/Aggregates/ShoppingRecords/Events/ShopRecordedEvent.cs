using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Aggregates.ShoppingRecords.Events
{
    public class ShopRecordedEvent : IDomainEvent
    {
        public ShopRecordedEvent(Shop shop)
        {
            Shop = shop;
        }
        public Shop Shop { get; }
    }
}
