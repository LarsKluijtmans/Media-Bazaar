using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotManager
{
    public interface IRestockDepotManager
    {
        List<Restock> GetAllRestockRequests();
        bool OrderRestock(int id, int amount);
        bool DeleteRestock(int id);
    }
}
