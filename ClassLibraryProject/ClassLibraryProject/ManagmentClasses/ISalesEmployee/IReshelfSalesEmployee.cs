using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.ISalesEmployee
{
    public interface IReshelfSalesEmployee
    {
        bool RequestReshelf(int id, Product product, int amount);
    }
}
