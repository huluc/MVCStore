using MVCStore.DAL.Abstract;
using MVCStore.DAL.Concrete.EntityFramework;
using MVCStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.DAL.Concrete.EntityFramework
{
    public class EfProductDal : EFRepositoryBase<Product, NorthwindContextDB>, IProductDal//Bu katmanda sadece DB işlemleri CRUD yapıldı. Open Closed principle a göre kodumuz gelişime açık değişime kapalı olmalı. Mesela burada sql db yerine MySql kullanmak istesek kodu değiştirip ekleme yapmamız gerekir. Fakat Interface ile soyutlasak (sql için olan da Mysql için olan da aynı şeyi hedefliyor) kodu değiştirmemize gerek kalmaz.
    {
        
    }
}
