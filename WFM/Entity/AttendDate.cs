using System;
using WFM.Enity;
using WFM.Properties;

namespace WFM.Entity
{
    public class AttendDate
    {
        public string Attend_Date_Id { get; set; }
        public DateTime Date { get; set; }
        public StaticResource.AttendDateType Type { get; set; }
        public User User { get; set; }
    }
}