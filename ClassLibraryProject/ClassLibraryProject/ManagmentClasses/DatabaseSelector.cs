using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.ManagmentClasses.IDepotEmployee;
using ClassLibraryProject.ManagmentClasses.IDepotManager;
using ClassLibraryProject.ManagmentClasses.ISalesEmployee;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses
{
    public class DatabaseSelector
    {
        private IDBRestock dbRestock;
        private IDBReshelf dbReshelf;
        private IDBOrderInfo dbOrderInfo;
        private IDBSupplier dbSupplier;
        private IDBSchedule dbSchedule;
        private IDBProduct dbProduct;

        private ProductManagement lgProduct;
        private OrderInfoManagment lgOrderInfo;
        private SupplierManagment lgSupplier;
        private ReshelfManagment lgReshelf;
        private RestockManagment lgRestock;

        private DepotEmployeeControl deControl;
        private DepotManagerControl dmControl;
        private SalesEmployeeControl seControl;
        
        public DepotEmployeeControl DEControl
        {
            get { return deControl; }
            private set { deControl = value; }
        }
        public DepotManagerControl DMControl
        {
            get { return dmControl; }
            private set { dmControl = value; }
        }
        public SalesEmployeeControl SEControl
        {
            get { return seControl; }
            private set { seControl = value; }
        }

        public DatabaseSelector()
        {
            dbSupplier = new DBSupplier();
            lgSupplier = new SupplierManagment(dbSupplier);

            dbProduct = new DBProductManager();
            lgProduct = new ProductManagement();

            dbOrderInfo = new DBOrderInfo(lgProduct, lgSupplier);
            lgOrderInfo = new OrderInfoManagment(dbOrderInfo);

            dbRestock = new DBRestock(lgProduct, lgOrderInfo);
            lgRestock = new RestockManagment(dbRestock);

            dbReshelf = new DBReshelf(lgProduct);
            lgReshelf = new ReshelfManagment(dbReshelf);

            dbSchedule = new DBSchedule();

            DEControl = new DepotEmployeeControl(lgReshelf, lgRestock);
            DMControl = new DepotManagerControl(lgRestock);
            SEControl = new SalesEmployeeControl(lgReshelf);
        }
    }
}
