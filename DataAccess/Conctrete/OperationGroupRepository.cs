using DataAccess.Abstract;
using Entities;

namespace DataAccess.Conctrete
{
    public class OperationGroupRepository:EfEntityRepositoryBase<OperationGroup, MsSqlDbContext>
    {
        public OperationGroupRepository(MsSqlDbContext context) : base(context)
        {
        }
    }
}