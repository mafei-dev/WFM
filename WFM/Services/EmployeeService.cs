using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Models;
using WFM.Repository;

namespace WFM.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepo _employeeRepo;

        public int AddNewEmployee(Employee employee)
        {
            employee.User_Id = Guid.NewGuid().ToString();
            _employeeRepo = new EmployeeRepo();
            return _employeeRepo.AddEMP(employee);
        }

        public List<Employee> SearchEMPByData(string data)
        {
            _employeeRepo = new EmployeeRepo();
            return _employeeRepo.SearchEMPByData(data);
        }
    }
}