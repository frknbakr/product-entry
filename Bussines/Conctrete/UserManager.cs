using System.Collections.Generic;
using Bussines.Abstract;
using DataAccess.Conctrete;
using Entities;
namespace Bussines.Conctrete
{
    public class UserManager : IUserServices
    {
        private readonly UserRepository userRepository = new UserRepository(new MsSqlDbContext());
        public void Create(User t)
        {
            userRepository.Add(t);
            userRepository.SaveChanges();
        }
        public void Update(User t)
        {
            userRepository.Update(t);
            userRepository.SaveChanges();
        }
        public void Delete(int id)
        {
            var findAddress = userRepository.Get(x => x.Id == id);
            userRepository.Delete(findAddress);
        }
        public IEnumerable<User> GetAll()
        {
            return userRepository.GetList();
        }
        public User GetById(int id)
        {
            return userRepository.Get(x => x.Id == id);
        }

        public User Login(string userName,string password)
        {
            var user = (userRepository.Get(x => x.Name == userName && x.Password == password));
            
            return user;
        }

        public IEnumerable<User> GetCustomers()
        {
            return userRepository.GetList(x => x.OperationGroupId == User.Groups.Customer);
        }
    }
}