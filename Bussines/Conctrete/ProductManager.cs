using System.Collections.Generic;
using DataAccess.Conctrete;
using Entities;

namespace Bussines.Conctrete
{
    public class ProductManager
    {
        readonly ProductRepository productRepository = new ProductRepository(new MsSqlDbContext());


        public void Create(Product address)
        {
            productRepository.Add(address);
            productRepository.SaveChanges();
        }

        public void Update(Product address)
        {
            productRepository.Update(address);
            productRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var findAddress = productRepository.Get(x => x.Id == id);
            productRepository.Delete(findAddress);
        }

        public IEnumerable<Product> GetAll()
        {
            return productRepository.GetList();
        }

        public Product GetById(int id)
        {
            return productRepository.Get(x => x.Id == id);
        }
    }
}