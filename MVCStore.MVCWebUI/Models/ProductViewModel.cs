using System.Collections.Generic;
using MVCStore.Entities.Concrete;

namespace MVCStore.MVCWebUI.Models
{
    public class ProductViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public List<Product> Products { get; set; }
    }

    public class PagingInfo
    {
        public int CurrentPage { get; internal set; }
        public int ItemsPerPage { get; internal set; }
        public int TotalItems { get; internal set; }
    }
}