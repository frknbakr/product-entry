using System.Collections.Generic;
using Bussines.Abstract;
using DataAccess.Conctrete;
using Entities;

namespace Bussines.Conctrete
{
    public class CategoryManager:ICategoryServices
    {
        readonly CategoryRepository categoryRepository = new CategoryRepository(new MsSqlDbContext());

        public void Create(Category category)
        {
            categoryRepository.Add(category);
            categoryRepository.SaveChanges();
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
            categoryRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var findCategory = categoryRepository.Get(x => x.Id == id);
            categoryRepository.Delete(findCategory);
        }

        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetList();
        }

        public Category GetById(int id)
        {
            return categoryRepository.Get(x => x.Id == id);
        }
    }
}