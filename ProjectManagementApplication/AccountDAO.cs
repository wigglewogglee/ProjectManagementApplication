namespace ProjectManagementApplication
{
    public class AccountDAO
    {

        private static List<UserAccount> registeredUsers = new();
        public static void retrieveFromServer()
        {
            //server call
            registeredUsers = new List<UserAccount>();
        }

        public static List<UserAccount> getRegisteredUsers()
        {

            retrieveFromServer();

            return registeredUsers;
        }
    }
}
