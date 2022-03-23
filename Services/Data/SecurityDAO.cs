//Security DAO = Security Data Access Object

using GroceryShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GroceryShop.Services.Data
{
    public class SecurityDAO
    {
        //connect to the database
        string connectionString = "Data Source=DESKTOP-822836A;Initial Catalog=groceryshop;Integrated Security=True";

        internal bool FindByUser(UserModel user)
        {
            bool success = false;

            //write the sql expression
            string queryString = "SELECT * FROM dbo.Users Where username = @Username AND password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar, 50).Value = user.Username;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 50).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return success;
        }
    }
}