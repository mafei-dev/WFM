using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WFM.Enity;
using WFM.Database;
using WFM.Properties;

namespace WFM.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private IUnitOfWork unitOfWork;

        public EmployeeRepo(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddEMP(Employee employee)
        {
            string sql =
                $@"INSERT INTO [dbo].[User]([First_Name], [Last_Name], [Address], [User_Id], [NIC], [Gender], [Birthday], [User_Type],[EMP_Id]) 
                            VALUES (@First_Name, @Last_Name, @Address, @User_Id, @NIC, @Gender , @Birthday, @User_Type, @EMP_Id);";
            return unitOfWork.Connection.Execute(sql, employee, unitOfWork.Transaction);
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
	                            [User].First_Name LIKE '%{data}%' AND [User].User_Type = {(int) StaticResource.UseType.EMPLOYEE_USER}";
            return unitOfWork.Connection.Query<Employee>(sql,null,unitOfWork.Transaction).ToList();
        }

        public Employee GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetByEMPId(string EMPId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EMPId", EMPId);
            string sql = $@"SELECT
	                            [User].First_Name, 
	                            [User].Last_Name, 
	                            [User].Address, 
	                            [User].User_Id, 
	                            [User].NIC,
	                            [User].EMP_Id
                            FROM
	                            dbo.[User]
                            WHERE
	                            [User].EMP_Id = @EMPId";
            return unitOfWork.Connection.Query<Employee>(sql, parameters, unitOfWork.Transaction).SingleOrDefault();
        }

        public List<Employee> GetAllEMPs()
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
	                            [User].User_Type = {(int) StaticResource.UseType.EMPLOYEE_USER}";
            return unitOfWork.Connection.Query<Employee>(sql, null, unitOfWork.Transaction).ToList();
        }

        public int GetTotalEmployees()
        {
	        string sql = $@"SELECT
								COUNT([User].User_Id)
							FROM
								dbo.[User]
							WHERE
								[User].User_Type = 2";
	        return unitOfWork.Connection.Query<int>(sql, null, unitOfWork.Transaction).SingleOrDefault();
        }
    }
}