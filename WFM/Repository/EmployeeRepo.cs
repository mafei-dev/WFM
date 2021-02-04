using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WFM.Models;
using WFM.Database;

namespace WFM.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {

        public EmployeeRepo(IUnitOfWork unitOfWork) 
        {
            this.unitOfWork = unitOfWork;
        } 
        private IUnitOfWork unitOfWork;
        public int AddEMP(Employee employee)
        {
            string sql =
                $@"INSERT INTO [dbo].[User]([First_Name], [Last_Name], [Address], [User_Id], [NIC], [Gender], [Birthday]) 
                            VALUES (@First_Name, @Last_Name, @Address, @User_Id, @NIC, @Gender , @Birthday);";
                return unitOfWork.Connection.Execute(sql, employee,unitOfWork.Transaction);
            
        }

        public int UpdateEMP(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> SearchEMPByData(string data)
        {
            
                string sql = $@"SELECT
	                            [User].First_Name, 
	                            [User].Last_Name, 
	                            [User].Address, 
	                            [User].User_Id, 
	                            [User].NIC
                            FROM
	                            dbo.[User]
                            WHERE
	                            [User].First_Name LIKE '%{data}%'";
                return unitOfWork.Connection.Query<Employee>(sql).ToList();
            
        }

        public Employee GetById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}