using System.Text.RegularExpressions;

namespace ProjectManagementApplication
{
    public class PasswordHandler
    {

        public static List<String> allowedUsernameChars = new List<String> {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "_", "." };

        public static Boolean matchesRegex(String username)
        {
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_.]{2,19}$";

            if (Regex.IsMatch(username, pattern))
            {
                return true;
            }

            return false;
        }

        public static Boolean validUsername(String username)
        {

            if (String.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            if (!matchesRegex(username))
            {
                return false;
            }

            return true;
        }

        public static void encryptPassword()
        {

        }
    }
}
