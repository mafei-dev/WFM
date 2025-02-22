﻿using System.Collections.Generic;
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

        public static class ExpenseTypes
        {
            public static string EMPLOYEE_EXPENSES = "Employee expenses";
            public static string ASSET_EXPENSES = "Asset expenses";
            public static string OTHER_EXPENSES = "Other expenses";
        }

        public static List<string> PROJECT_STATUS = new List<string>()
        {
            "Not Started",
            "Active",
            "In Development",
            "Pending",
            "Scheduled",
            "Quality Control",
            "In Progress",
            "Keep Watch",
            "On Hold",
            "Pending Approval",
            "Canceled",
            "Complete"
        };
        
        public static List<string> EXP_TYPE = new List<string>()
        {
            "Utility bills",
            "Lease ",
            "Vehicle insurance",
            "Vehicle maintenance",
            "Eating out",
            "Parking",
            "Fuel ",
            "Other"
        };

        public static List<string> ASSETS_TYPE = new List<string>()
        {
            "Vehicles",
            "Furniture ",
            "Patents",
            "Investments",
            "Land",
            "Building",
            "Machinery",
            "Trademarks",
            "Other"
        };



    }
}