using System.Collections.Generic;
using Bussines.Abstract;
using DataAccess.Conctrete;
using Entities;

namespace Bussines.Conctrete
{
    public class TechnicalServicesManager:ITechnicalServices
    {
        
        private readonly TechnicalServicesRepository technicalServicesRepository = new TechnicalServicesRepository(new MsSqlDbContext());

      
        public void Create(TechnicalService t)
        {
            technicalServicesRepository.Add(t);
            technicalServicesRepository.SaveChanges();
        }

        public void Update(TechnicalService t)
        {
            technicalServicesRepository.Update(t);
            technicalServicesRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var findAddress = technicalServicesRepository.Get(x => x.Id == id);
            technicalServicesRepository.Delete(findAddress);
        }

        public IEnumerable<TechnicalService> GetAll()
        {
            return technicalServicesRepository.GetList();
        }

        public TechnicalService GetById(int id)
        {
            return technicalServicesRepository.Get(x => x.Id == id);
        }
    }
}