using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFM.Enity;

namespace WFM.Repository
{
    interface IEmployeeRepo
    {

        int AddEMP(Employee employee);
        int UpdateEMP(Employee employee);
        List<Employee> SearchEMPByData(string data);
        Employee GetById(string id);
        Employee GetByEMPId(string EMPId);

        List<Employee> GetAllEMPs();
    }
}
