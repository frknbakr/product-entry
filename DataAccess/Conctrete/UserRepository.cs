using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class UserRepository: EfEntityRepositoryBase<User,MsSqlDbContext>
    {
        public UserRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}