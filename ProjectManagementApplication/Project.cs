namespace ProjectManagementApplication
{
    public class Project
    {

        public string name { get; set; } = "Project";
        public int checkpoints { get; set; } = 0;

        public Project()
        {
        }

        public Project(string name, int checkpoints)
        {
            this.name = name;
            this.checkpoints = checkpoints;
        }
    }
}
