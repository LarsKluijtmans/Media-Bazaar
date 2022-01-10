using System;
using System.Collections.Generic;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using ClassLibraryProject.ManagmentClasses.IProductManager;
using MySql.Data.MySqlClient;

namespace ClassLibraryProject.ManagmentClasses
{
    public class OrderInfoManagment: IOrderInfoProductManager, IGetOrderInfo
    {
        private List<int> numbers = new List<int>();
        public int id()
        {
            int n = 1;
            Random random = new Random();
            for (int i = 1000; i < 9999; i++)
            {
                numbers.Add(i);
            }
            foreach (int i in numbers)
            {
                n = random.Next(numbers.Count);
                if (i == numbers[n])
                {
                    numbers.Remove(i);
                    return i;
                }
            }
            return n;
        }

        private IDBOrderInfo db;

        public OrderInfoManagment(IDBOrderInfo dbOrderInfo)
        {
            db = dbOrderInfo;
        }

        public List<OrderInfo> GetOrderInfos()
        {
            return db.GetOrderInfos();
        }
        public bool AddOrderInfo(Supplier supplier, Product product, int minAmount, int maxAmount, int multiples)
        {
            if(db.AddOrderInfo(id(), supplier, product, minAmount, maxAmount, multiples) == true)
            {
                return true;
            }
            return false;
        }
        public bool DeleteOrderInfo(int id)
        {
            if (OrderInfoExist(id) == true)
            {
                if (db.DeleteOrderInfo(id))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool UpdateOrderInfo(int id, int minAmount, int maxAmount, int multiples)
        {
            if (OrderInfoExist(id) == true)
            {
                if (db.UpdateOrderInfo(id, minAmount, maxAmount, multiples))
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public OrderInfo GetOrderInfo(int id)
        {
            foreach(OrderInfo orderInfo in db.GetOrderInfos())
            {
                if(orderInfo.ID == id)
                {
                    return orderInfo;
                }
            }
            return null;
        }
        private bool OrderInfoExist(int id)
        {
            if (GetOrderInfo(id) != null)
            {
                return true;
            }
            return false;
        }
    }
}
