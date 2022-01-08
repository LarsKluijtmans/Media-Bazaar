using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject
{
    public class DBContractManager : IDBContractManager
    {
        // sql
        public static string CREATE_CONTRACT;
        public static string READ_CONTRACT;
        public static string UPDATE_CONTRACT;
        public static string DELETE_CONTRACT;

        public bool CreateContract(Contract c)
        {
            throw new NotImplementedException();
        }

        public bool DeleteContract(Contract c)
        {
            throw new NotImplementedException();
        }

        public Contract ReadContract(Employee e)
        {
            throw new NotImplementedException();
        }

        public bool UpdateContract(Contract c)
        {
            throw new NotImplementedException();
        }
    }
}
