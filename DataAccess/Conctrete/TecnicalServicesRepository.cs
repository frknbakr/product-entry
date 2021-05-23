using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class TechnicalServicesRepository: EfEntityRepositoryBase<TechnicalService, MsSqlDbContext>
    {
        public TechnicalServicesRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}