using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotEmployee
{
    public interface IReshelfDepotEmployee
    {
        List<Reshelf> GetReshelfRequests();
        bool CompleteReshelf(int id, Product product);
        bool DeleteReshelf(int id);
    }
}
