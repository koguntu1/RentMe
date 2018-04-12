using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.DAL;
using RentMe.Models;

namespace RentMe.Controller
{
    public static class StoreItemController
    {
        public static int AddStoreItem(Store_item storeItem)
        {
            return Store_ItemDAL.AddStoreItem(storeItem);
        }
    }
}
