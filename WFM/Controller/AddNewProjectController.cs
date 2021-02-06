using System.Collections.Generic;
using WFM.Database;
using WFM.Enity;
using WFM.Entity;
using WFM.Properties;
using WFM.Repository;

namespace WFM.Controller
{
    public class AddNewProjectController : IAddNewProjectController
    {
        private IUserRepository _userRepository;
        private IProjectRepository _projectRepository;

        public List<User> GetAllClients()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _userRepository = new UserRepository(unitOfWork);
                    List<User> list = _userRepository.GetAllUsers();
                    unitOfWork.Commit();
                    return list;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }

        public bool AddNewProject(Project project)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _projectRepository = new ProjectRepository(unitOfWork);
                    int addNewProject = _projectRepository.AddNewProject(project);
                    if (addNewProject == 1)
                    {
                        unitOfWork.Commit();
                        return true;
                    }
                    else
                    {
                        unitOfWork.Rollback();
                        return false;
                    }
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }   
            }
        }

        public List<User> SearchUserByName(string name)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _userRepository = new UserRepository(unitOfWork);
                    List<User> list = _userRepository.SearchUserByName(name, StaticResource.UseType.CLIENT_USER);
                    unitOfWork.Commit();
                    return list;
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