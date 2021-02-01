using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Models;

namespace WFM.Presenters
{
    interface IAddNewEmployee
    {
        User AddUser { set; }
    }
}
