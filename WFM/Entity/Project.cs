using System;
using WFM.Enity;

namespace WFM.Entity
{
    public class Project
    {
        public Project()
        {
        }

        public Project(string projectId)
        {
            Project_Id = projectId;
        }

        public string Project_Id { get; set; }
        public string Project_Name { get; set; }
        public string Project_Note { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public DateTime Estimated_End_Date { get; set; }
        public string Cost { get; set; }
        public User Client { get; set; }
        public string Status { get; set; }
    }

    public class ProjectWithClient : Project
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
    }
}