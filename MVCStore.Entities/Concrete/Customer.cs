using MVCStore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCStore.Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
    }
}
