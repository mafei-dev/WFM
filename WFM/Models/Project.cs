using System;
using WFM.Enity;

namespace WFM.Models
{
    public class Project
    {
        public string Project_Id { get; set; }
        public string Project_Name { get; set; }
        public string Project_Note { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public DateTime Estimated_End_Date { get; set; }
        public Decimal Cost { get; set; }
        public User Client { get; set; }
        public string Status { get; set; }
    }
}