using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IProductManager
{
    public class ProductManagerControl
    {
        private IOrderInfoProductManager orderInfo;
        private ISupplierProductManager supplier;

        public ProductManagerControl(IOrderInfoProductManager orderInfo, ISupplierProductManager supplier)
        {
            this.orderInfo = orderInfo;
            this.supplier = supplier;
        }

        //order info
        public List<OrderInfo> GetOrderInfos()
        {
            return orderInfo.GetOrderInfos();
        }
        public bool AddOrderInfo(Supplier supplier, Product product, int minAmount, int maxAmount, int multiples)
        {
            return orderInfo.AddOrderInfo(supplier, product, minAmount, maxAmount, multiples);
        }
        public bool UpdateOrderInfo(int id, int minAmount, int maxAmount, int multiples)
        {
            return orderInfo.UpdateOrderInfo(id, minAmount, maxAmount, multiples);
        }
        public bool DeleteOrderInfo(int id)
        {
            return orderInfo.DeleteOrderInfo(id);
        }

        //supplier
        public List<Supplier> GetSuppliers()
        {
            return supplier.GetSuppliers();
        }
        public bool AddSupplier(string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber)
        {
            return supplier.AddSupplier(name, country, buildingNumber, postalCode, email, phoneNumber, bankNumber);
        }
        public bool UpdateSupplier(int id, string name, string country, int buildingNumber, string postalCode, string email, int phoneNumber, string bankNumber)
        {
            return supplier.UpdateSupplier(id, name, country, buildingNumber, postalCode, email, phoneNumber, bankNumber);
        }
        public bool DeleteSupplier(int id)
        {
            return supplier.DeleteSupplier(id);
        }
    }
}
