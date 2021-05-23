namespace Entities
{
    public class OrderProduct:IEntity
    {
        public int Id { get; set; }
        public int ProductId{ get; set; }
        public int OrderId{ get; set; }
    }
}