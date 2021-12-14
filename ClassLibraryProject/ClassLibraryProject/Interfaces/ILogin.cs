using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Interfaces
{
    public interface ILogin
    {
        public Employee CheckLogin(string UserName, string Password);
        public int GetID(string UserName, string Password);
    }
}
