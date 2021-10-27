using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.Class
{
	public class Schedule
	{

		private int id;
		private string department;
		private string day;
		private int morningAmount;
		private int afternoonAmount;
		private int eveningAmount;

		public int ID
        {
			get { return id; }
			set { id = value; }
		}
		public string Department
		{
			get { return department; }
			set { department = value; }
		}

		public string Day
		{
			get { return day; }
			set { day = value; }
		}

		public int MorningAmount
		{
            get { return morningAmount; }
			set { morningAmount = value; }
        }

		public int AfternoonAmount
		{
			get { return afternoonAmount; }
            set { afternoonAmount = value; }
        }

		public int EveningAmount
		{
			get { return eveningAmount; }
			set { eveningAmount = value; }
        }
	   
		public Schedule(int id, string department, string day, int morningAmount, int afternoonAmount, int eveningAmount)
        {
			ID = id;
			Department = department;
			Day = day;
			MorningAmount = morningAmount;
			AfternoonAmount = afternoonAmount;
			EveningAmount = eveningAmount;
        }	
	}
}


	