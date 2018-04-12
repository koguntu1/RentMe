using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.DAL;
using RentMe.Models;

namespace RentMe.Controller
{
    public static class CategoryController
    {
        public static List<Category> GetCategoryList()
        {
            return CategoryDAL.GetCategoryList();
        }

        public static Category GetCategory(int categoryID)
        {
            return CategoryDAL.GetCategory(categoryID);
        }
    }
}
