using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryShop.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string ProductCategories { get; set; }
        public string InStock { get; set; }
        public string ProductDetails { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

        public ProductModel()
        {
            ProductId = 1;
            ProductName = "Rice";
            BrandName = "Shahi Chal";
            ProductCategories = "Daily Product";
            InStock = "Yes";
            ProductDetails = "alsdkfj";
            Price = "120";
            Image = "img.png";
        }

        public ProductModel(int productId, string productName, string brandName, string productCategories, string inStock, string productDetails, string price, string image)
        {
            ProductId = productId;
            ProductName = productName;
            BrandName = brandName;
            ProductCategories = productCategories;
            InStock = inStock;
            ProductDetails = productDetails;
            Price = price;
            Image = image;
        }
    }
}