namespace ProjectManagementApplication
{
    public class AccountDAO
    {

        private static List<UserAccount> registeredUsers = new();
        public static void retrieveFromServer()
        {
            //server call
            registeredUsers = new List<UserAccount>();

            //temp
            registeredUsers.Add(new UserAccount("john_doe", "john", "testpass"));
        }

        public static List<UserAccount> getRegisteredUsers()
        {
            return registeredUsers;
        }

        public static Boolean registryContainsUsername(String username)
        {
            foreach (UserAccount account in registeredUsers)
            {
                if (account.username.Equals(username))
                {
                    return true;
                }
            }

            return false;
        }

        public static Boolean registryContainsPassword(String password)
        {
            foreach (UserAccount account in registeredUsers)
            {
                if (account.encryptedPassword.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
