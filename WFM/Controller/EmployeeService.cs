using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Database;
using WFM.Enity;
using WFM.Models;
using WFM.Repository;

namespace WFM.Controller
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepo _employeeRepo;
        private IAdminRepository _adminRepository;

        public int AddNewEmployee(User user)
        {
            if (user.Equals(typeof(Employee)))
            {
                using (DalSession dalSession = new DalSession())
                {
                    UnitOfWork unitOfWork = dalSession.UnitOfWork();
                    unitOfWork.Begin();

                    try
                    {
                        user.User_Id = Guid.NewGuid().ToString();
                        _employeeRepo = new EmployeeRepo(unitOfWork);
                        if (_employeeRepo.AddEMP((Employee) user) == 1)
                        {
                            unitOfWork.Commit();
                            return 1;
                        }
                        else
                        {
                            unitOfWork.Rollback();
                            return 0;
                        }
                    }
                    catch
                    {
                        unitOfWork.Rollback();
                        throw;
                    }
                }
            }
            else if (user.Equals(typeof(AdminUser)))
            {
                using (DalSession dalSession = new DalSession())
                {
                    UnitOfWork unitOfWork = dalSession.UnitOfWork();
                    unitOfWork.Begin();

                    try
                    {
                        user.User_Id = Guid.NewGuid().ToString();
                        _adminRepository = new AdminRepository(unitOfWork);
                        if (_adminRepository.AddAdminUser((AdminUser) user) == 1)
                        {
                            unitOfWork.Commit();
                            return 1;
                        }
                        else
                        {
                            unitOfWork.Rollback();
                            return 0;
                        }
                    }
                    catch
                    {
                        unitOfWork.Rollback();
                        throw;
                    }
                }
            }
            else
            {
                throw new Exception();
            }
        }

        public List<Employee> SearchEMPByData(string data)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                _employeeRepo = new EmployeeRepo(unitOfWork);
                return _employeeRepo.SearchEMPByData(data);
            }
        }
    }
}