using MVCStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCStore.Entities.Concrete;
using System.Linq.Expressions;
using MVCStore.DAL.Concrete.EntityFramework;
using MVCStore.DAL.Abstract;

namespace MVCStore.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           return _categoryDal.GetAll();
        }

        public void Update(Category product)
        {
            throw new NotImplementedException();
        }
    }
}
