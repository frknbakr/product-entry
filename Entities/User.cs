using System;
namespace Entities
{
    public class User:IEntity
    {
        public enum Groups
        {
            Technician=1,
            Customer,
            Salesman
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Groups OperationGroupId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
    }
}