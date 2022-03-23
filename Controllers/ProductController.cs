using GroceryShop.Models;
using GroceryShop.Services.Data;
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
            ProductDAO productDAO = new ProductDAO();

            products = productDAO.FetchAll();

            return View("Index", products);
        }
    }
}