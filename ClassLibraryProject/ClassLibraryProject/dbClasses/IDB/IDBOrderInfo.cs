using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBOrderInfo
    {
        List<OrderInfo> GetOrderInfos();
        bool AddOrderInfo(OrderInfo oi);
        bool UpdateOrderInfo(int id, int minAmount, int maxAmount, int multiples);
        bool DeleteOrderInfo(int id);
    }
}
