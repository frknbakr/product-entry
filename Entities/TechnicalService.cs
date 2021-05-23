using System;

namespace Entities
{
    public class TechnicalService:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double TotalPrice { get; set; }
        public string Description { get; set; }
        public int TechnicalId { get; set; }
    }
}