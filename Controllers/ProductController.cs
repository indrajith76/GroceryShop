using GroceryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroceryShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            //genarate some fake data and send it to a view
            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel(1, "Potato", "Pran", "Dryfoods", "Yes", "potato details", "10", "potato.jpg"));
            products.Add(new ProductModel(2, "Soyabin Oil", "Fresh", "Daily Product", "Yes", "oil details", "130", "Oil.jpg"));

            return View("Index", products);
        }
    }
}