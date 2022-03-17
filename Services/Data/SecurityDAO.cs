using GroceryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroceryShop.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            //if (user.Username == "admin" && user.Password == "1234")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            //Alternative way to write the functions.
            return (user.Username == "admin" && user.Password == "1234");
        }
    }
}