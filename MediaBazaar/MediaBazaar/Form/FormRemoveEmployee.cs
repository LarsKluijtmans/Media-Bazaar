using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MediaBazaar.Class;
using MySql.Data.MySqlClient;


namespace MediaBazaar
{
    public partial class FormRemoveEmployee : Form
    {
        Person employee;
        public FormRemoveEmployee(Person p)
        {
            InitializeComponent();
            this.employee = p;
            lblEmployee.Text = $"{p.ID} - {p.FirstName} {p.LastName}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateContract();
        }
        public void UpdateContract()
        {
            string employeeID = p.EmployeeID.ToString();
            string reasonForTermination = tbxReasonTermination.Text;
            string contractEndDate = tbxEndDate.Text;


            MySqlConnection conn = Utils.GetConnection();
            string sql = Utils.UPDATE_CONTRACT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ReasonForTermination", reasonForTermination);
                cmd.Parameters.AddWithValue("@EndDate", contractEndDate);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                MessageBox.Show(msqEx.Message);
            }
            catch (Exception ex)
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
