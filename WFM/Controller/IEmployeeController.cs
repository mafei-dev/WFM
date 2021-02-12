using System.Collections.Generic;
using WFM.Enity;
using WFM.Properties;

namespace WFM.Controller
{
    public interface IEmployeeController
    {
        
        int AddNewEmployee(User user, StaticResource.UseType useType);
        List<Employee> SearchEMPByData(string data);
    }
}