using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class OrderRepository : EfEntityRepositoryBase<Order, MsSqlDbContext>
    {
        public OrderRepository(MsSqlDbContext context) : base(context)
        {

        }
    }
}