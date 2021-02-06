using System.Collections.Generic;
using WFM.Enity;

namespace WFM.Controller
{
    public interface IEmployeeService
    {
        
        int AddNewEmployee(User user);
        List<Employee> SearchEMPByData(string data);
    }
}