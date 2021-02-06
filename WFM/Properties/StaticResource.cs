using System.Collections.Generic;
using System.ComponentModel;

namespace WFM.Properties
{
    public static class StaticResource
    {
        public enum AttendanceType
        {
            [Description("IN")] IN = 1,
            [Description("OUT")] OUT = 2
        }

        public enum AttendDateType
        {
            [Description("Working Day")] LEAVE_DAY = 1,
            [Description("Leave Day")] WORKING_DAY = 2
        }

        public enum UseType
        {
            [Description("All User")] All = 0,
            [Description("Admin User")] ADMIN_USER = 1,
            [Description("Employee User")] EMPLOYEE_USER = 2,
            [Description("Client User")] CLIENT_USER = 3
        }

        public static class UseTypes
        {
            public static string ADMIN_USER = "Admin";
            public static string EMPLOYEE_USER = "Employee";
            public static string CLIENT_USER = "Client";
        }
    }
}