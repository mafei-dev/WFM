using System.Collections.Generic;
using WFM.Models;

namespace WFM.Services
{
    public interface IEmployeeService
    {
        int AddNewEmployee(Employee employee);
        List<Employee> SearchEMPByData(string data);
    }
}