using Microsoft.VisualBasic;

namespace ProjectManagementApplication
{
    public class UserAccount
    {

        public string username { get; set; } = "";
        public string email { get; set; } = "";
        public string encryptedPassword { get; set; } = "";

        public UserAccount()
        {
        }

        public UserAccount(string username, string email, string encryptedpassword)
        {
            this.username = username; 
            this.email = email;
            this.encryptedPassword = encryptedpassword;
        }
    }
}
