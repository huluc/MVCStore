using MVCStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.Interfaces
{
    [ServiceContract]
    public interface IProductService
    {
        //Bir sınıfı WCF servisi olarak yayına çıkarmak için [ServiceContract], [OperationContract]
        [OperationContract]
        List<Product> GetAll();
        //[OperationContract]
        //Product Get(Expression<Func<Product, bool>> filter);
        [OperationContract]
        void Add(Product product);
        [OperationContract]
        void Update(Product product);
        [OperationContract]
        void Delete(int productId);
    }
}
