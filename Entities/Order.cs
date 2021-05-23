using System;

namespace Entities
{
    public class Order:IEntity
    {
        public enum Status
        {

            Received,
            OnFixing,
            Fixed,
            Delivered,
            }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public Status OrderStatus { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}