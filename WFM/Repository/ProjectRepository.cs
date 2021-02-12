using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private IUnitOfWork unitOfWork;

        public ProjectRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddNewProject(Project project)
        {
            Console.WriteLine("project.Client.User_Id {0}",project.Client.User_Id);
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Project_Id", project.Project_Id);
            parameters.Add("@Project_Name", project.Project_Name);
            parameters.Add("@Project_Note", project.Project_Note);
            parameters.Add("@Start_Date", project.Start_Date);
            parameters.Add("@End_Date", null);
            parameters.Add("@Cost", project.Cost);
            parameters.Add("@Status", project.Status);
            parameters.Add("@Estimated_End_Date", project.Estimated_End_Date);
            string sql =
                $@"INSERT INTO [dbo].[Project]([Project_Id], [Project_Name], [Project_Note], [Start_Date], [End_Date], [Cost], [Client_Id], [Status], [Estimated_End_Date]) 
                   VALUES (@Project_Id, @Project_Name, @Project_Note, @Start_Date, @End_Date, @Cost, '{project.Client.User_Id}', @Status, @Estimated_End_Date);";


            return unitOfWork.Connection.Execute(sql, parameters, unitOfWork.Transaction);
        }

        public List<ProjectWithClient> GetAllProjects()
        {
            string sql = $@"SELECT
							Project.Project_Id,
							Project.Project_Name,
							Project.Project_Note,
							Project.Start_Date,
							Project.End_Date,
							Project.Cost,
							Project.Client_Id,
							Project.Status,
							Project.Estimated_End_Date,
							[User].First_Name,
							[User].Last_Name 
						FROM
							dbo.Project
							INNER JOIN dbo.[User] ON Project.Client_Id = [User].User_Id;";

            return unitOfWork.Connection.Query<ProjectWithClient>(sql, null, unitOfWork.Transaction).AsList();
        }

        public int GetTotalProjects()
        {
	        string sql = $@"SELECT
							COUNT(Project.Project_Id)
						FROM
							dbo.Project;";

	        return unitOfWork.Connection.Query<int>(sql, null, unitOfWork.Transaction).SingleOrDefault();
        }
        
        
    }
}