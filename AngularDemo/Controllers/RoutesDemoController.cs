using System;
using System.Web.Mvc;
using AngularDemo.Models;

namespace AngularDemo.Controllers
{
    public class RoutesDemoController : Controller
    {
        // GET: RoutesDemo
        public ActionResult One()
        {
            ViewBag.ServerThread = System.Threading.Thread.CurrentThread.ManagedThreadId;
            return View();
        }
        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;
            return View();
        }
        [Authorize]
        public ActionResult Three()
        {
            return View();
        }

        public JsonResult GetSerializedProducts()
        {
            System.Diagnostics.Debug.WriteLine("controller getting products...");
            var products = new[] 
            { 
                new Product{Id=1,Name="product1",Price=4500,Description="description of this product"},
                new Product{Id=2,Name="product2",Price=500,Description="description of this product"},
                new Product{Id=3,Name="product3",Price=400,Description="description of this product"},
                new Product{Id=4,Name="product4",Price=5500,Description="description of this product"},
                new Product{Id=5,Name="product5",Price=66500,Description="description of this product"}
            };
            //var settings = new JsonSerializerSettings { ContractResolver=new CamelCasePropertyNamesContractResolver()};
            //return JsonConvert.SerializeObject(products,Formatting.None,settings);
            return Json(products);
        }
    }

}