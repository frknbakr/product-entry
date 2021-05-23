﻿namespace Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }
        public int CategoryId { get; set; }
    }
}