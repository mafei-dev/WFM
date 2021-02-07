using System.Collections.Generic;
using WFM.Enity;
using WFM.Properties;

namespace WFM.Controller
{
    public interface IEmployeeService
    {
        
        int AddNewEmployee(User user, StaticResource.UseType useType);
        List<Employee> SearchEMPByData(string data);
    }
}