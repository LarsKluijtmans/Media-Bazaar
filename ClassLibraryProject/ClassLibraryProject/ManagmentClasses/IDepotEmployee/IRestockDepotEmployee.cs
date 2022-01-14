using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotEmployee
{
    public interface IRestockDepotEmployee
    {
        List<Restock> GetOrderedRestockRequests();
        bool RequestRestock(Product product);
        bool RestockExist(Product product);
        bool ReceiveRestock(int id, Product product);
    }
}
