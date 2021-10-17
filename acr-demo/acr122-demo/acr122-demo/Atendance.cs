﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace acr122_demo
{
    class Atendance
    {
        public List<Ckecks> check;
        public static string GET_EMPLOYEEID_WITH_CARD_CODE = "SELECT `EmployeeID` FROM `employee` WHERE `CardNumber`= @CardNumber;";
        public static string IS_CHECKED_IN = "SELECT employeeID FROM `atendance` WHERE EmployeeID = @EmployeeID AND CheckDate = @CheckDate AND `CheckOutTime` IS NULL;";
        public static string CREATE_CHECKIN = "INSERT INTO ATENDANCE(EmployeeID, CheckInTime, CheckOutTime, CheckDate) VALUES(@EmployeeID, @CheckInTime, @CheckOutTime, @CheckDate)";
        public static string UPDATE_CHECKOUT = "UPDATE ATENDANCE SET CheckOutTime = @CheckOutTime WHERE CheckDate = @CheckDate AND EmployeeID = @EmployeeID AND `CheckOutTime` IS NULL ;";
        public static string GET_ALL_ATENDANCE = "SELECT `EmployeeID`,`CheckInTime`,`CheckOutTime`,`CheckDate` FROM `atendance`;";


        public Atendance()
        {
            check = new List<Ckecks>();
        }

        public void getAllAtendance()
        {
            check.Clear();
            MySqlConnection conn = Connection.GetConnection();

            string sql = GET_ALL_ATENDANCE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                Ckecks a;

                while (reader.Read())
                {
                    a = new Ckecks(Convert.ToInt32( reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                    check.Add(a);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        public int GetEmployeeID(string CardNumber)
        {
            MySqlConnection conn = Connection.GetConnection();

            string sql = GET_EMPLOYEEID_WITH_CARD_CODE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return Convert.ToInt32(reader[0]);
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public bool IsAlreadyCheckedIn(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Connection.GetConnection();
            string sql = IS_CHECKED_IN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return true;
                }
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public void AddCheckIn(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Connection.GetConnection();
            string sql = CREATE_CHECKIN;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckInTime", date.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CheckOutTime", null);
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                int n = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }

        public void EditCheckOutTime(int EmployeeID)
        {
            var date = DateTime.Now;
            MySqlConnection conn = Connection.GetConnection();
            string sql = UPDATE_CHECKOUT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID.ToString());
                cmd.Parameters.AddWithValue("@CheckOutTime", date.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@CheckDate", date.ToString("yyyy-MM-dd"));

                conn.Open();
                int n = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
