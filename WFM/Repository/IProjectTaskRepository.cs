using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface IProjectTaskRepository
    {
        int AddNewProjectTask(ProjectTask projectTask);
        List<ProjectTaskNormalised> GetAllTasksForProject(string projectId);
    }
}