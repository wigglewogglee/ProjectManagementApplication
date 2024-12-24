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
            projects.Add(new Project("project2", 3));
            projects.Add(new Project("project3", 3));
            projects.Add(new Project("project4", 3));
            projects.Add(new Project("project5", 3));
        }

        public static List<Project> getProjects()
        {

            retrieveFromServer();

            return projects;
        }
    }
}
