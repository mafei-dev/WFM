using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Models;

namespace WFM.Repository
{
    interface IEmployeeRepo
    {

        int AddEmp(Employee employee);
        int UpdateEmp(Employee employee);
        List<Employee> SearchEmpsByData(string data);
        Employee GetById(string id);
    }
}
