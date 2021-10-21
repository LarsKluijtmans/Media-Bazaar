using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    public partial class Admin : Form
    {
        int ID;
        Store store;

        public Admin(int userID, Store s)
        {
            InitializeComponent();
            ID = userID;
            store = s;

            if (AmountOfEmployees() >= 2)
            {
                gbMakeEmployee.Visible = false;
                btnBackup.Visible = true;
                labBackup.Visible = true;
            }
            else 
            {
                gbMakeEmployee.Visible = true;
                btnBackup.Visible = false;
                labBackup.Visible = false;
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string username = $"{lastName.ToLower()}";
            string password = $"{lastName.ToLower()}";
            int bsn = Convert.ToInt32(tbxBSN.Text);
            string city = tbxCity.Text;
            string email = $"{lastName.ToLower()}@mb.com";
            int phoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            string dateOfBirth = tbxDateOfBirth.Text;

            MySqlConnection conn = Utils.GetConnection();
            string sql = EmployeeManagement.CREATE_EMPLOYEE;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@BSN", bsn);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;

                tbxEmployeeID.Text = id.ToString();
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

            tbxUsername.Text = username;
            tbxPassword.Text = password;
            tbxEmail.Text = email;
         }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(tbxEmployeeID.Text);
            string jobTitle = cbxJobTitle.Text.ToString();
            int workHoursPerWeek = Convert.ToInt32(tbxWorkHours.Text);
            int salary = Convert.ToInt32(tbxSalary.Text);
            string startDate = tbxStartDate.Text;

            MySqlConnection conn = Utils.GetConnection();
            string sql = ContractManagement.CREATE_CONTRACT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@WorkHoursPerWeek", workHoursPerWeek);
                cmd.Parameters.AddWithValue("@SalaryPerHour", salary);
                cmd.Parameters.AddWithValue("@StartDate", startDate);

                conn.Open();

                int numCreatedRows = cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;

                tbxEmployeeID.Text = id.ToString();
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

        public int AmountOfEmployees()
        {
            MySqlConnection conn = Utils.GetConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(EMPLOYEEid) FROM employee;", conn);
                conn.Open();


                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    return Convert.ToInt16(reader[0]);
                }
                return 0;
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
            return 0;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This might take a minute");

            string constring = "Server=studmysql01.fhict.local;Uid=dbi461266;Database=dbi461266;Pwd=Nijlpaard;SslMode =none;";

            string file = @"D:\CompanyDatabase\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }

            MessageBox.Show(@"Backup sucsesfull, please go to the D:\CompanyDatabase for the backup.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("lars.kluijtmans@gmail.com", "Nijlpaard"),
                EnableSsl = true,
            };

            StringBuilder message = new StringBuilder();

            message.Append(" <h1>Here is your acount information.</h1>");
            message.AppendLine("<p>Here is your acount information.</p>");
            message.AppendLine("<p>You can use these in the diferent mediabazaar apps and websites.</p>");
            message.AppendLine("<p>  Username: lkluijtmans</p>");
            message.AppendLine("<p>  password: 1 </p>");
            message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

            var mailMessage = new MailMessage
            {
                From = new MailAddress("lars.kluijtmans@gmail.com"),
                Subject = "Mediabazaar acount information",
                Body = message.ToString(),
                IsBodyHtml = true,
            };
            mailMessage.To.Add("");
            //lars.kluijtmans @gmail.com

            smtpClient.Send(mailMessage);

            MessageBox.Show("Email send");
        }
    }
}
