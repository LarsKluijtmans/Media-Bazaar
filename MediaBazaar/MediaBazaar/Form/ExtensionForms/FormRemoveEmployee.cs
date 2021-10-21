using System;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;


namespace MediaBazaar
{
    public partial class FormRemoveEmployee : Form
    {
        Person employee;
        Contract contract;
        int saveCount;
        public FormRemoveEmployee(Person p, Contract c)
        {
            InitializeComponent();
            this.employee = p;
            this.contract = c;
            lblEmployee.Text = $"{p.EmployeeID} - {p.FirstName} {p.LastName}";
            saveCount = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateContract();
            saveCount++;
        }
        public void UpdateContract()
        {
            string employeeID = employee.EmployeeID.ToString();
            string reasonForTermination = tbxReasonTermination.Text;
            if (string.IsNullOrEmpty(reasonForTermination))
            {
                MessageBox.Show("Please enter a reason for termination");
            }
            string contractEndDate = tbxEndDate.Text;
            if (string.IsNullOrEmpty(contractEndDate))
            {
                MessageBox.Show("Please enter a contract end date");
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = ContractManagement.END_CONTRACT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
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
                MessageBox.Show("Something went wrong" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (saveCount == 1)
            {
                MessageBox.Show("Make sure to save the data");
                saveCount = 0;
            }
        }
    }
}
