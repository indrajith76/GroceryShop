using GroceryShop.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GroceryShop.Services.Data
{
    internal class ProductDAO
    {
        private string connectionString = "Data Source=DESKTOP-822836A;Initial Catalog=groceryshop;Integrated Security=True";
        //perform all oparations on the database. get all, create, delete, get one, search etc.
        public List<ProductModel> FetchAll()
        {
            List<ProductModel> returnList = new List<ProductModel>();

            //access the database
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from dbo.Products";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new product object. add it to the list to return.
                        ProductModel product = new ProductModel();
                        product.ProductId = reader.GetInt32(0);
                        product.ProductName = reader.GetString(1);
                        product.BrandName = reader.GetString(2);
                        product.ProductCategories = reader.GetString(3);
                        product.InStock = reader.GetString(4);
                        product.ProductDetails = reader.GetString(5);
                        product.Price = reader.GetString(6);
                        product.Image = reader.GetString(7);

                        returnList.Add(product);
                    }
                }
            }
            return returnList;
        }

    }
}