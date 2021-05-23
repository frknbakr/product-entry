namespace Entities
{
    public class Address:IEntity
    {
        public int Id { get; set; }
        public string AddressName { get; set; }
        public int UserId { get; set; }
        public string FullAddress { get; set; }
    }
}