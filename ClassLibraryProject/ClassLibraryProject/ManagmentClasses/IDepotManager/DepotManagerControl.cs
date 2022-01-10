using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IDepotManager
{
    public class DepotManagerControl
    {
        private IRestockDepotManager restock;

        public DepotManagerControl(IRestockDepotManager restock)
        {
            this.restock = restock;
        }

        //restock
        public List<Restock> GetRestockRequests()
        {
            return restock.GetRestockRequests();
        }
        public bool OrderRestock(int id, OrderInfo orderInfo, int amount)
        {
            return restock.OrderRestock(id, orderInfo, amount);
        }
        public bool DeleteRestock(int id)
        {
            return restock.DeleteRestock(id);
        }
    }
}
