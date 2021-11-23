using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
namespace ClassLibraryProject.ManagmentClasses
{
   public class CompanyManagment
    {
        ICompanyManagment icompanyManagment;
        public CompanyManagment(ICompanyManagment companyManagment)
        {
            icompanyManagment = companyManagment;
        }
        
        public Company GetCompany(int UserID)
        {
            return icompanyManagment.GetCompany(UserID);
        }

        public void EditCompany(string Name, string Adress, string PhoneNumber, string Email, string BTW, string KVK, string ID)
        {
            icompanyManagment.EditCompany(Name,Adress, PhoneNumber, Email, BTW, KVK, ID);
        }
    }
}
