using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface IProjectRepository
    {
        int AddNewProject(Project project);
        List<ProjectWithClient> GetAllProjects();
        int GetTotalProjects();
    }
}