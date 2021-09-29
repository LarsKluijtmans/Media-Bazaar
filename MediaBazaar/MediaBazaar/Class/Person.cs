using System;
using System.Collections.Generic;
using System.Text;


namespace MediaBazaar
{
	public abstract class Person
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
		private string preferedWorkTime;
		private string leastPreferedWorkTime;

		// properties
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public int PhoneNumber { get; set; }
		public string City { get; set; }
		public string DateOfBirth { get; set; }
		public int BSN { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public int ID { get; set; }

		//constructor

		public Person(int employeeID, string firstname, string lastname, int phonenumber, string email, string city, string dateofbirth, int bsn, string username, string password)
		{

			this.ID = employeeID;
			this.LastName = firstname;
			this.FirstName = lastname;
			this.PhoneNumber = phonenumber;
			this.Email = email;
			this.City = city;
			this.DateOfBirth = dateofbirth;
			this.BSN = bsn;
			this.Username = username;
			this.Password = password;
		
		}
		// methodes
		public override string ToString()
		{
			return $"ID: {ID} - Name: {FirstName} {LastName} - Email: {Email} - PhoneNumber: {PhoneNumber}";
		}
		public void SelectWorkTime(string preferedWorkTime, string leastPreferedWorkTime)
        {
			this.preferedWorkTime = preferedWorkTime;
			this.leastPreferedWorkTime = leastPreferedWorkTime;
        }
	}
}
 

	