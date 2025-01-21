namespace ProjectManagementApplication
{
    public class ProjectDAO
    {

        private static List<Project> projects = new List<Project>();
        public static void retrieveFromServer()
        {
            //server call
            projects.Clear();

            //datetime as year/month/day

            projects.Add(new Project("PROJECT NAME", 3, new DateTime(2023, 02, 01), "DONE"));
            projects.Add(new Project("PROJECT NAME", 3, new DateTime(2025, 06, 23), "INPROGRESS"));
            projects.Add(new Project("PROJECT NAME", 3, new DateTime(2023, 02, 01), "DONE"));
            projects.Add(new Project("PROJECT NAME", 3, new DateTime(2023, 02, 01), "MINORPROGRESS"));
            projects.Add(new Project("PROJECT NAME", 3, new DateTime(2023, 02, 01), "DONE"));
        }

        public static List<Project> getProjects()
        {

            retrieveFromServer();

            return projects;
        }
    }
}
