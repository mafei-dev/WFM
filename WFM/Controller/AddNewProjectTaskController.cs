using System;
using System.Collections.Generic;
using WFM.Database;
using WFM.Entity;
using WFM.Repository;

namespace WFM.Controller
{
    public class AddNewProjectTaskController
    {
        private IProjectTaskRepository _projectTaskRepository;
        private IProjectRepository _projectRepository;

        public bool AddNewProjectTask(ProjectTask projectTask)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _projectTaskRepository = new ProjectTaskRepository(unitOfWork);
                    projectTask.Added_Datetime = DateTime.Now;
                    projectTask.Project_Task_Id = Guid.NewGuid().ToString();
                    if (_projectTaskRepository.AddNewProjectTask(projectTask) == 1)
                    {
                        unitOfWork.Commit();
                        return true;
                    }
                    else
                    {
                        unitOfWork.Rollback();
                        return true;
                    }
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }

        public List<ProjectWithClient> LoadAllProjects()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _projectRepository = new ProjectRepository(unitOfWork);
                    List<ProjectWithClient> projectWithClients = _projectRepository.GetAllProjects();
                    unitOfWork.Commit();
                    return projectWithClients;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }
    }
}