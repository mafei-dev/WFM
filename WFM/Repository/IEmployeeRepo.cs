using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Models;

namespace WFM.Repository
{
    interface IEmployeeRepo
    {

        int AddEMP(Employee employee);
        int UpdateEMP(Employee employee);
        List<Employee> SearchEMPByData(string data);
        Employee GetById(string id);
    }
}
