using System.Collections.Generic;
using WFM.Enity;

namespace WFM.Controller
{
    public interface IEmployeesController
    {
        List<User> GetAllUsers();
    }
}