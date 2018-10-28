using MVCStore.Entities.Concrete;
using MVCStore.Interfaces;
using MVCStore.MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStore.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public int PageSize =6;
        public ActionResult Index(int page=1, int category=0)
        {
            List<Product> products = _productService.GetAll().Where(p=>p.CategoryId==category||category==0).ToList();
            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * PageSize).Take(PageSize).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage=PageSize,
                    TotalItems = products.Count,
                    CurrentPage = page
                }
            }
            );
        }
    }
}