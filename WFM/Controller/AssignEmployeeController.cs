using System;
using System.Collections.Generic;
using WFM.Database;
using WFM.Enity;
using WFM.Entity;
using WFM.Exception;
using WFM.Repository;

namespace WFM.Controller
{
    public class AssignEmployeeController
    {
        private IProjectRepository _projectRepository;
        private IEmployeeRepo _employeeRepo;
        private IProjectEmployeeRepository _projectEmployeeRepository;


        public List<ProjectEmployeeExpanded> GetAllEmployeesForProject(string projectId)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    // _projectRepository = new ProjectRepository(unitOfWork);
                    _projectEmployeeRepository = new ProjectEmployeeRepository(unitOfWork);
                    List<ProjectEmployeeExpanded> allAssignedEmployeesByProjectId =
                        _projectEmployeeRepository.GetAllAssignedEmployeesByProjectId(projectId);

                    unitOfWork.Commit();
                    return allAssignedEmployeesByProjectId;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }


        public List<Employee> SearchUserProject(string text)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _employeeRepo = new EmployeeRepo(unitOfWork);
                    List<Employee> searchEmpByData = _employeeRepo.SearchEMPByData(text);

                    unitOfWork.Commit();
                    return searchEmpByData;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }

        public bool AddNewEmpToProject(string EMPId, string projectId)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _projectEmployeeRepository = new ProjectEmployeeRepository(unitOfWork);
                    int existing = _projectEmployeeRepository.CheckEmployeeIsExisting(EMPId, projectId);

                    Console.WriteLine("existing {0}", existing);
                    if (existing == 0)
                    {
                        //can add 
                        ProjectEmployee projectEmployee = new ProjectEmployee();
                        projectEmployee.Project_Employee_id = Guid.NewGuid().ToString();
                        projectEmployee.Added_Datetime = DateTime.Today;
                        projectEmployee.Project_Id = new Project(projectId);
                        projectEmployee.User_Id = new User(EMPId);

                        int response = _projectEmployeeRepository.AddNewProjectEmployee(projectEmployee);
                        if (response == 1)
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
                    else
                    {
                        // unitOfWork.Rollback();
                        throw new EmployeeAlreadyExistException();
                    }
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }

        public bool RemoveEmpFromProject(string Project_Employee_id)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _projectEmployeeRepository = new ProjectEmployeeRepository(unitOfWork);
                    int response = _projectEmployeeRepository.RemoveEmpFromProject(Project_Employee_id);
                    if (response == 1)
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
                    throw;
                }
            }
        }
    }
}