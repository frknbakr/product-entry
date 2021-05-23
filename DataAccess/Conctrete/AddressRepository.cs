using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class AddressRepository: EfEntityRepositoryBase<Address,MsSqlDbContext>
    {
        public AddressRepository(MsSqlDbContext context) : base(context)
        {

        }
    }
}