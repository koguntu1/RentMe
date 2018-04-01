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
        public Furniture GetFurniture(int furnitureID)
        {
            return FurnitureDAL.GetFurniture(furnitureID);
        }
    }
}
