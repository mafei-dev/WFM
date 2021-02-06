using System;
using WFM.Enity;

namespace WFM.Entity
{
    public class ProjectEmployee
    {
        public string Project_Employee_id { get; set; }
        public User User_Id { get; set; }
        public Project Project_Id { get; set; }
        public DateTime Added_Datetime { get; set; }
    }

    public class ProjectEmployeeExpanded
    {
        public string Project_Employee_id { get; set; }

        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public string EMP_Id { get; set; }
        public string User_Id { get; set; }
        
        public DateTime Added_Datetime { get; set; }
    }
}