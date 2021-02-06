using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface IProjectEmployeeRepository
    {
        List<ProjectEmployeeExpanded> GetAllAssignedEmployeesByProjectId(string projectId);

        int CheckEmployeeIsExisting(string empId,string projectId);

        int AddNewProjectEmployee(ProjectEmployee projectEmployee);
        int RemoveEmpFromProject(string projectEmployeeId);
    }
}