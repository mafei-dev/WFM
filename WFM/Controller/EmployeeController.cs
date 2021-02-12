using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Database;
using WFM.Enity;
using WFM.Entity;
using WFM.Models;
using WFM.Properties;
using WFM.Repository;

namespace WFM.Controller
{
    public class EmployeeController : IEmployeeController
    {
        private IEmployeeRepo _employeeRepo;
        private IAdminRepository _adminRepository;
        private IClientRepository _clientRepository;

        public int AddNewEmployee(User user, StaticResource.UseType useType)
        {
            if (useType == StaticResource.UseType.EMPLOYEE_USER)
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
            else if (useType == StaticResource.UseType.ADMIN_USER)
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
            else if (useType == StaticResource.UseType.CLIENT_USER)
            {
                using (DalSession dalSession = new DalSession())
                {
                    UnitOfWork unitOfWork = dalSession.UnitOfWork();
                    unitOfWork.Begin();

                    try
                    {
                        user.User_Id = Guid.NewGuid().ToString();
                        _clientRepository = new ClientRepository(unitOfWork);
                        if (_clientRepository.AddClient((Client) user) == 1)
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
                throw new System.Exception();
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