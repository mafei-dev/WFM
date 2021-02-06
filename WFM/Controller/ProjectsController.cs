using System.Collections.Generic;
using WFM.Database;
using WFM.Entity;
using WFM.Repository;

namespace WFM.Controller
{
    public class ProjectsController
    {
        private IProjectRepository _projectRepository;

        public List<ProjectWithClient> GetAllProjects()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();

                try
                {
                    _projectRepository = new ProjectRepository(unitOfWork);
                    List<ProjectWithClient> projects = _projectRepository.GetAllProjects();
                    unitOfWork.Commit();
                    return projects;
                }
                catch
                {
                    unitOfWork.Commit();
                    throw;
                }
            }
        }
    }
}