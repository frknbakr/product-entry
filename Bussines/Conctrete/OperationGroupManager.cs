using System.Collections.Generic;
using Bussines.Abstract;
using DataAccess.Conctrete;
using Entities;

namespace Bussines.Conctrete
{
    public class OperationGroupManager:IOperationGroupServices
    {
        readonly OperationGroupRepository opeatiopnGroupRepository = new OperationGroupRepository(new MsSqlDbContext());


        public void Create(OperationGroup operationGroup)
        {
            opeatiopnGroupRepository.Add(operationGroup);
            opeatiopnGroupRepository.SaveChanges();
        }

        public void Update(OperationGroup operationGroup)
        {
            opeatiopnGroupRepository.Update(operationGroup);
            opeatiopnGroupRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var findOperationGroup = opeatiopnGroupRepository.Get(x => x.Id == id);
            opeatiopnGroupRepository.Delete(findOperationGroup);
        }

        public IEnumerable<OperationGroup> GetAll()
        {
            return opeatiopnGroupRepository.GetList();
        }

        public OperationGroup GetById(int id)
        {
            return opeatiopnGroupRepository.Get(x => x.Id == id);
        }
    }
}