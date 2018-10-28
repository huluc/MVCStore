using MVCStore.BLL.Concrete;
using MVCStore.DAL.Concrete.EntityFramework;
using MVCStore.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCStore.MVCWebUI.Infrastructure
{
    //MVC nin Controller larda nasıl bir yorumlama yapması gerektiğini söylüyoruz. Senin ctorunda senden x Interface i istenirse ona y yi ver 
    //MVC ye bundan sonra NinjectControllerFactory kullan demek için Global.asax a kayıt et.
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _ninjectKernel;
        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal", new EfProductDal());// Controller Ctor unda IProductService istenirse ona ProductMaanger ver.
            _ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null :(IController) _ninjectKernel.Get(controllerType);
        }
    }
}