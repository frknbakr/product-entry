using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using Bussines.Abstract;
using DataAccess.Conctrete;
using Entities;

namespace Bussines
{
    public class AddressManager:IAddressServices
    {
        readonly AddressRepository addressRepository = new AddressRepository(new MsSqlDbContext());


        public void Create(Address address)
        {
            addressRepository.Add(address);
            addressRepository.SaveChanges();
        }
        public int CreateSendId(Address address)
        {
            addressRepository.Add(address);
            addressRepository.SaveChanges();
            return address.Id;
        }

        public void Update(Address address)
        {
            addressRepository.Update(address);
            addressRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var findAddress = addressRepository.Get(x => x.Id == id);
            addressRepository.Delete(findAddress);
        }

        public IEnumerable<Address> GetAll()
        {
            return addressRepository.GetList();
        }

        public Address GetById(int id)
        {
            return addressRepository.Get(x => x.Id == id);
        }
    }
}