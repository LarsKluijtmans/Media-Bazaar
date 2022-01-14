using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses.IDB;
using ClassLibraryProject.dbClasses.IGetObject;
using ClassLibraryProject.ManagmentClasses.IAllManager;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class ScheduleManagment: IScheduleAllManager, IGetSchedule
    {
        private IDBSchedule dbSchedule;

        public ScheduleManagment(IDBSchedule db)
        {
            dbSchedule = db;
        }

        //read
        public List<Schedule> GetSchedules(string department, int year, int week)
        {
            List<Schedule> schedules = new List<Schedule>();

            if(GetSchedule(department, year, week) != null)
            {
                schedules.Add(GetSchedule(department, year, week));
            }
            return schedules;
        }
        public Schedule GetSchedule(string department, int year, int week)
        {
            foreach (Schedule schedule in dbSchedule.GetSchedules())
            {
                if (schedule.Department == department && schedule.Year == year && schedule.Week == week)
                {
                    return schedule;
                }
            }
            return null;
        }

        //create
        public bool CreateWeek(string department, int year, int week)
        {
            if (!WeekExist(department, year, week))
            {
                if(dbSchedule.CreateWeek(department, year, week) == true)
                {
                    return true; 
                }
                return false;
            }
            return false;
        }
        
        
        //update
        public bool UpdateSchedule(string department, int year, int week, string day, int morningAmount, int afternoonAmount, int eveningAmount)
        {
            if(WeekExist(department, year, week))
            {
                if(dbSchedule.UpdateSchedule(department, year, week, day, morningAmount, afternoonAmount, eveningAmount) == true)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //check
        public bool WeekExist(string department, int year, int week)
        {
            if (GetSchedule(department, year, week) != null)
            {
                return true;
            }
            return false;
        }
    }
}
