using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
    public class Employee
    {
        private int employeeID;
		private string firstName;
		private string lastName;
		private int phoneNumber;
		private string email;
		private string city;
		private string dateOfBirth;
		private int bsn;
		private string username;
		private string password;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public int PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}
		public string City
		{
			get { return city; }
			set { city = value; }
		}
		public string DateOfBirth
		{
			get { return dateOfBirth; }
			set { dateOfBirth = value; }
		}
		public int BSN
		{
			get { return bsn; }
			set { bsn = value; }
		}
		public string Username
		{
			get { return username; }
			set { username = value; }
		}
		public string Password
		{
			get { return password; }
			set { password = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public int ID
		{
			get { return employeeID; }
			set { employeeID = value; }
		}

		public Employee(int employeeID, string firstname, string lastname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
		{
			ID = employeeID;
			LastName = firstname;
			FirstName = lastname;
			PhoneNumber = phonenumber;
			Email = email;
			City = city;
			DateOfBirth = dateofbirth;
			BSN = bsn;
			Username = username;
			Password = password;

		}
		public Employee(int id)
		{
			ID = id;
		}

		public override string ToString()
		{
			return $"ID: {ID} - Name: {FirstName} {LastName}";
		}
	}
}
