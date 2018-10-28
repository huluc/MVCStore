using MVCStore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.DAL.Concrete.EntityFramework
{
    public class NorthwindContextDB : DbContext // bu classı DbContext ten türetebilmek için EF ref olarak eklenmeli.
    {
        public NorthwindContextDB()
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
