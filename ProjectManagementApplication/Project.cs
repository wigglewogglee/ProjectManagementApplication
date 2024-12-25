using Microsoft.VisualBasic;

namespace ProjectManagementApplication
{
    public class Project
    {

        public string name { get; set; } = "Project";
        public int checkpoints { get; set; } = 0;

        public DateTime dueDate = DateTime.MinValue;

        private String projectStatus = "";

        public Project()
        {
        }

        public Project(string name, int checkpoints, DateTime dueDate, String projectStatus)
        {
            this.name = name;
            this.checkpoints = checkpoints;
            this.dueDate = dueDate;
            this.projectStatus = projectStatus;
        }

        public String getDueDate()
        {
            return dueDate.Month + "/" + dueDate.Day + "/" + dueDate.Year;
        }

        public String getProjectStatus()
        {
            return this.projectStatus;
        }
    }
}
