﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFM
{
    public static class Helper
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["WFM"].ConnectionString;
        }
    }
}