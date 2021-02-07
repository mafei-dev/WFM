using System;
using System.Collections.Generic;
using WFM.Database;
using WFM.Enity;
using WFM.Properties;
using WFM.Repository;

namespace WFM.Controller
{
    public class EmployeesController : IEmployeesController
    {
        private IUserRepository _userRepository;

        public List<User> GetAllUsers()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _userRepository = new UserRepository(unitOfWork);
                    List<User> allUsers = _userRepository.GetAllUsers();
                    Console.WriteLine("allUsers {0}", allUsers);
                    unitOfWork.Commit();
                    return allUsers;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }

        public List<User> SearchEmployeeByName(string text)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _userRepository = new UserRepository(unitOfWork);
                    List<User> searchUserByNameList =
                        _userRepository.SearchUserByName(text, StaticResource.UseType.EMPLOYEE_USER);
                    unitOfWork.Commit();
                    return searchUserByNameList;
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