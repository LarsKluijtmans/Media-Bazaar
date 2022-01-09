using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IProductManager
{
    public interface IOrderInfoProductManager
    {
        List<OrderInfo> GetOrderInfos();
        bool AddOrderInfo(Supplier supplier, Product product, int minAmount, int maxAmount, int multiples);
        bool UpdateOrderInfo(int id, int minAmount, int maxAmount, int multiples);
        bool DeleteOrderInfo(int id);
    }
}
