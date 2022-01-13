using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotEmployee
{
    public interface IDepotEmployeeControl
    {
        List<Reshelf> GetReshelfRequest();
        bool CompleteReshelf(int id, Product product);
        bool DeleteReshelf(int id);
        List<Restock> GetOrderedRestockRequests();
        bool RequestRestock(Product product);
        bool ReceiveRestock(int id, Product product);
    }
}
