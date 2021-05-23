using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class OrderProductRepository: EfEntityRepositoryBase<OrderProduct,MsSqlDbContext>
    {
        public OrderProductRepository(MsSqlDbContext context) : base(context)
        {

        }
    }
}