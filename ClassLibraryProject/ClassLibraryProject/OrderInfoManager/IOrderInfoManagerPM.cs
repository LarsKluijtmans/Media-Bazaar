using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IOrderInfoManagerPM
    {
        public List<OrderInfo> GetOrderInfosForProduct(Product p);
    }
}
