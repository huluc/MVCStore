using MVCStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.DAL.Abstract
{
    public interface IProductDal :IRepository<Product>
    {
        
    }
}
