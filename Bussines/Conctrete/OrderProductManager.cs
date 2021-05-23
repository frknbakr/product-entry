using Bussines.Abstract;
using DataAccess.Conctrete;
using Entities;
using System.Collections.Generic;

namespace Bussines.Conctrete
{
    public class OrderProductManager : IOrderProductServices
    {
        readonly OrderProductRepository orderProductRepository = new OrderProductRepository(new MsSqlDbContext());
        public void Create(OrderProduct address)
        {
            orderProductRepository.Add(address);
            orderProductRepository.SaveChanges();
        }

        public void Update(OrderProduct address)
        {
            orderProductRepository.Update(address);
            orderProductRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var findAddress = orderProductRepository.Get(x => x.Id == id);
            orderProductRepository.Delete(findAddress);
        }

        public IEnumerable<OrderProduct> GetAll()
        {
            return orderProductRepository.GetList();
        }

        public OrderProduct GetById(int id)
        {
            return orderProductRepository.Get(x => x.Id == id);
        }

        IEnumerable<OrderProduct> IServicesBase<OrderProduct>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}