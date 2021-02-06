using System.Collections.Generic;
using WFM.Enity;
using WFM.Entity;

namespace WFM.Controller
{
    public interface IAddNewProjectController
    {
        List<User> SearchUserByName(string name);
        List<User> GetAllClients();

        bool AddNewProject(Project project);

    }
}