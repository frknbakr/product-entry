using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class ProductRepository: EfEntityRepositoryBase<Product, MsSqlDbContext>
    {
        public ProductRepository(MsSqlDbContext context) : base(context)
        {

        }
    }
}