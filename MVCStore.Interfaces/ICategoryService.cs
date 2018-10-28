using MVCStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.Interfaces
{
    public interface ICategoryService //Bu katmanı web servis de iş sınıfı da kullanmış olacak. Kod tekrarından ve birbirinden kopuk olmasınan kurtulmuş olduk.
    {
        List<Category> GetAll(Expression<Func<Product, bool>> filter=null);
        Category Get(Expression<Func<Product, bool>> filter);
        void Add(Category product);
        void Update(Category product);
        void Delete(int productId);
    }
}
