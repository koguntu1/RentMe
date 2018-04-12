using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.DAL;
using RentMe.Models;

namespace RentMe.Controller
{
    public static class StyleController
    {
        public static List<Style> GetStyleList()
        {
            return StyleDAL.GetStyleList();
        }

        public static Style GetStyle(int styleID)
        {
            return StyleDAL.GetStyle(styleID);
        }
    }
}
