﻿using ClassLibraryProject.Class;
using System;

namespace ClassLibraryProject.ChildClasses
{
  public class ProductManager : Employee
    {
        public ProductManager() : base()
        { }
        public ProductManager(string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {

        }
        public ProductManager(int employeeID, string firstName, string lastName, int phoneNumber, string email, string city, DateTime dateOfBirth, int bsn, string username, string password)
       : base(employeeID, firstName, lastName, phoneNumber, email, city, dateOfBirth, bsn, username, password)
        {

        }
    }
}
