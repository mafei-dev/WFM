using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Database;
using WFM.Models;
using WFM.Repository;

namespace WFM.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepo _employeeRepo;

        public int AddNewEmployee(Employee employee)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();

                try
                {
                    employee.User_Id = Guid.NewGuid().ToString();
                    _employeeRepo = new EmployeeRepo(unitOfWork);
                    if (_employeeRepo.AddEMP(employee) == 1)
                    {
                        unitOfWork.Commit();
                        return 1;
                    }
                    else {
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