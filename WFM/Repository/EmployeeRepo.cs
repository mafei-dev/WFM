using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WFM.Models;

namespace WFM.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public int AddEMP(Employee employee)
        {
            string sql = $@"INSERT INTO [dbo].[User]([First_Name], [Last_Name], [Address], [User_Id], [NIC]) 
                            VALUES (@First_Name, @Last_Name, @Address, @User_Id, @NIC);";
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionString()))
            {
                return connection.Execute(sql, employee);
            }
            
        }

        public int UpdateEMP(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> SearchEMPByData(string data)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionString()))
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
                return connection.Query<Employee>(sql).ToList();
            }
        }

        public Employee GetById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}