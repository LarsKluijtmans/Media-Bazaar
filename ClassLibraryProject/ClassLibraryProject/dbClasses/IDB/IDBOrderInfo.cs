using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.dbClasses.IDB
{
    public interface IDBOrderInfo
    {
        public List<OrderInfo> GetOrderInfos();
        public bool AddOrderInfo(OrderInfo oi);
        public bool UpdateOrderInfo(int id, int minAmount, int maxAmount, int multiples);
        public bool DeleteOrderInfo(int id);
    }
}
