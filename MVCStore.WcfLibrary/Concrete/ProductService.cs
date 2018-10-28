using MVCStore.BLL.Concrete;
using MVCStore.DAL.Concrete.EntityFramework;
using MVCStore.Entities.Concrete;
using MVCStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        //SOA standartlarına göre bir servisin ctor u olmaz. O yüzden Dependency Inj. yapmadık Ctorda. Bu bağımlılığı ileride;
        //Instance Provider ile ezilecek.
        private ProductManager _productManager = new ProductManager(new EfProductDal());
        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }


        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }
    }
}
