using System.Collections.Generic;
using System.Linq;
using Dapper;
using WFM.Database;
using WFM.Enity;
using WFM.Entity;
using WFM.Properties;

namespace WFM.Repository
{
    public class ProjectEmployeeRepository : IProjectEmployeeRepository
    {
        private IUnitOfWork unitOfWork;

        public ProjectEmployeeRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public List<ProjectEmployeeExpanded> GetAllAssignedEmployeesByProjectId(string projectId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Project_Id", projectId);

            string sql = $@"SELECT
							[User].First_Name, 
							[User].Last_Name, 
							[User].EMP_Id, 
							Project_Employee.Added_Datetime, 
							Project_Employee.Project_Employee_id, 
							[User].User_Id
						FROM
							dbo.Project_Employee
							INNER JOIN
							dbo.[User]
							ON 
								Project_Employee.User_Id = [User].User_Id
							INNER JOIN
							dbo.Project
							ON 
								Project_Employee.Project_Id = Project.Project_Id
						WHERE
							Project.Project_Id = @Project_Id AND
							[User].User_Type = {(int) StaticResource.UseType.EMPLOYEE_USER};";

            return unitOfWork.Connection.Query<ProjectEmployeeExpanded>(sql, parameters, unitOfWork.Transaction)
                .ToList();
        }

        public int CheckEmployeeIsExisting(string empId, string projectId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Emp_Id", empId);
            parameters.Add("@Project_Id", projectId);
            string sql = @"SELECT
								COUNT([User].User_Id) 
							FROM
								dbo.Project_Employee
								INNER JOIN
								dbo.[User]
								ON 
									Project_Employee.User_Id = [User].User_Id
								INNER JOIN
								dbo.Project
								ON 
									Project_Employee.Project_Id = Project.Project_Id
							WHERE
								Project.Project_Id = @Project_Id AND
								Project_Employee.User_Id = @Emp_Id;";
            return unitOfWork.Connection.Query<int>(sql, parameters, unitOfWork.Transaction).SingleOrDefault();
        }

        public int AddNewProjectEmployee(ProjectEmployee projectEmployee)
        {
            string sql =
                $@"INSERT INTO [dbo].[Project_Employee]([Project_Employee_id], [Added_Datetime], [User_Id], [Project_Id]) VALUES (@Project_Employee_id, @Added_Datetime, '{projectEmployee.User_Id.User_Id}', '{projectEmployee.Project_Id.Project_Id}');";
            return unitOfWork.Connection.Execute(sql, projectEmployee, unitOfWork.Transaction);
        }

        public int RemoveEmpFromProject(string projectEmployeeId)
        {
            string sql =
                $@"DELETE FROM [dbo].[Project_Employee] WHERE Project_Employee.Project_Employee_id='{projectEmployeeId}';";
            return unitOfWork.Connection.Execute(sql, null, unitOfWork.Transaction);
        }
    }
}