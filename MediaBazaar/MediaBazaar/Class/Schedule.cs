using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar.Class
{
	abstract class Schedule
	{

		private int id;
		private string firststName;
		private string lasttName;
		private string date;

	public int ID
        {

			get { return id; }
			set { id = value; }

		}

	 public string FirstName
        {
            get { return firststName; }
			set { firststName = value; }
        }

		public string LastName
        {
			get { return lasttName; }
            set { lasttName = value; }
        }

		public string Date
        {
			get { return date; }
			set { date = value; }
        }
	   
		public Schedule(int id, string date)
        {
			ID = id;
			Date = date;
        }
		
		
		public string Viewschedule()
        {
		
				return $" Name: {FirstName} {LastName} - Date: {Date}";
		}
	
		
}
}


	