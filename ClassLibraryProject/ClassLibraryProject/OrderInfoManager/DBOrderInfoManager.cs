using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class DBOrderInfoManager : IDBOrderInfoManagerPM
    {
        // sql
        public string GET_ORDER_INFOS_FOR_PRODUCT = "SELECT * FROM OrderInfo as o INNER JOIN Supplier as s on o.SupplierID = s.SupplierID WHERE ProductBarcode = @ProductBarcode;";


        public List<OrderInfo> GetOrderInfosForProduct(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
