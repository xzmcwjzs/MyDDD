using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XZMCWJZS.DDD.Domain.Model;
using XZMCWJZS.DDD.Domain.Repositories;
using XZMCWJZS.DDD.Repository.EntityFramework;
using XZMCWJZS.DDD.WCF.Application.ServiceContracts;
using XZMCWJZS.DDD.WCF.Application.ServiceImplementations;
using XZMCWJZS.DDD.Web.ProductService;

namespace XZMCWJZS.DDD.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
         
        public ActionResult Index()
        {
            using (var proxy = new ProductServiceClient())
            {
                var product = proxy.GetProducts();
                return View(product.ToList());
            }
            //XZMCWJZS.DDD.WCF.Application.ServiceContracts.IProductService service =new ProductServiceImp (new ProductRepository(new EntityFrameworkRepositoryContext()),new CategoryRepository(new EntityFrameworkRepositoryContext()));
            //var product = service.GetProducts();
            //return View(product.ToList()); 
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            using (var proxy = new ProductServiceClient())
            {
                proxy.Add(product);
                return RedirectToAction("Index");
            }  
        }


    }
}