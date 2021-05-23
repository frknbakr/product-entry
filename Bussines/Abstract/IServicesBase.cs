using System.Collections.Generic;

namespace Bussines.Abstract
{
    public interface IServicesBase<T>
    {
        void Create(T t);
        void Update(T t);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}