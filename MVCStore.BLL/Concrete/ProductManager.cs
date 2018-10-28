using MVCStore.DAL.Abstract;
using MVCStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCStore.Entities.Concrete;
using System.Linq.Expressions;

namespace MVCStore.BLL.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal; //Farklı frameworkler(EF,NHibernate vb.) kullanma ihtimaline karşı Dependency Injection 
        public ProductManager(IProductDal productDal)
        {
             _productDal= productDal ;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        //public Product Get(Expression<Func<Product, bool>> filter)
        //{
        //    return _productDal.Get(filter);
        //}

        public List<Product> GetAll(Expression<Func<Product, bool>> filter=null)
        {
            return _productDal.GetAll(filter);
        }

        public List<Product> GetAll()
        {
           return  _productDal.GetAll();
        }
    }
}
