using System;
using WFM.Properties;

namespace WFM.Entity
{
    public class Attendance
    {
        public string Attendance_Id { get; set; }
        public DateTime Datetime { get; set; }
        public StaticResource.AttendanceType Type { get; set; }
        public AttendDate AttendDate { get; set; }
    }

    public class AttendanceView : Attendance
    {
        public TimeSpan Datetime { get; set; }
    }


}