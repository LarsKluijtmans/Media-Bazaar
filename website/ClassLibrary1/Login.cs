using System.ComponentModel.DataAnnotations;



namespace ClassLibrary1
{
    public class Login
    {

        public Login()
        {

        }
        public Login(string userName, string password, string fisrtname, string lastname, string email, string department, string shift)
        {
            UserName = userName;
            Password = password;
            Firstname = fisrtname;
            Lastname = lastname;
            Email = email;
            Department = department;
            Shift = shift;
        }

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Shift { get; set; }

    }
}

