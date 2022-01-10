using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotManager
{
    public interface IRestockDepotManager
    {
        List<Restock> GetRestockRequests();
        bool OrderRestock(int id, OrderInfo orderInfo, int amount);
        bool DeleteRestock(int id);
    }
}
