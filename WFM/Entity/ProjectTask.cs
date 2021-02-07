using System;

namespace WFM.Entity
{
    public class ProjectTaskPure
    {
        public string Project_Task_Id { get; set; }
        public string Task_Name { get; set; }
        public string Task_Note { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public DateTime Added_Datetime { get; set; }
    }

    public class ProjectTask : ProjectTaskPure
    {
        public Project Project { get; set; }
    }

    public class ProjectTaskNormalised : ProjectTaskPure
    {
        public string Project_Id { get; set; }
    }
}