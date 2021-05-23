using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class CategoryRepository:EfEntityRepositoryBase<Category,MsSqlDbContext>
    {
        public CategoryRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}