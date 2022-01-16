using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public interface IDBOrderInfoManagerPM
    {
        public List<OrderInfo> GetOrderInfosForProduct(Product p);
        public bool CreateOrderInfo(OrderInfo oi);
    }
}
