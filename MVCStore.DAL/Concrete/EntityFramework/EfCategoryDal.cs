using MVCStore.DAL.Abstract;
using MVCStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.DAL.Concrete.EntityFramework
{
    public class EfCategoryDal:EFRepositoryBase<Category,NorthwindContextDB>,ICategoryDal
    {
    }
}
