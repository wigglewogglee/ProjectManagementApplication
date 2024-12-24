namespace ProjectManagementApplication
{
    public class ProjectDAO
    {

        private static List<Project> projects = new();
        public static void retrieveFromServer()
        {
            //server call
            projects = new List<Project>();

            projects.Add(new Project("project1", 3));
        }

        public static List<Project> getProjects()
        {

            retrieveFromServer();

            return projects;
        }
    }
}
