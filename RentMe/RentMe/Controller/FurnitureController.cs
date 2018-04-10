using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.DAL;
using RentMe.Models;

namespace RentMe.Controller
{
    class FurnitureController
    {
        public static List<Furniture> GetFurnitureList()
        {
            return FurnitureDAL.GetFurnitureList();
        }

        public List<Furniture> GetFurniture(int furnitureID, int itemID, int categoryID, int styleID)
        {
            return FurnitureDAL.GetFurniture(furnitureID, itemID, categoryID, styleID);
        }

        public static int AddFurniture(Furniture furniture)
        {
            return FurnitureDAL.AddFurniture(furniture);
        }

        public static bool UpdateFurniture(Furniture oldFurniture, Furniture newFurniture)
        {
            return FurnitureDAL.UpdateFurniture(oldFurniture, newFurniture);
        }
    }
}
