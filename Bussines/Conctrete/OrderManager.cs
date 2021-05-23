using System.Collections.Generic;
using DataAccess.Conctrete;
using Entities;

namespace Bussines.Conctrete
{
    public class OrderManager
    {
        readonly OrderRepository orderRepository = new OrderRepository(new MsSqlDbContext());


        public void Create(Order address)
        {
            orderRepository.Add(address);
            orderRepository.SaveChanges();
        }
        public int CreateSendId(Order address)
        {
            orderRepository.Add(address);
            orderRepository.SaveChanges();
            return address.AddressId;
        }

        public void Update(Order address)
        {
            orderRepository.Update(address);
            orderRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var findAddress = orderRepository.Get(x => x.Id == id);
            orderRepository.Delete(findAddress);
        }

        public IEnumerable<Order> GetAll()
        {
            return orderRepository.GetList();
        }

        public Order GetById(int id)
        {
            return orderRepository.Get(x => x.Id == id);
        }
    }
}