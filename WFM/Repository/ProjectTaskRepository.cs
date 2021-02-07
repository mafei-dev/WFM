using System.Collections.Generic;
using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class ProjectTaskRepository : IProjectTaskRepository
    {
        private IUnitOfWork unitOfWork;

        public ProjectTaskRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddNewProjectTask(ProjectTask projectTask)
        {
            string sql =
                $@"INSERT INTO [dbo].[Project_Task]([Project_Task_Id], [Task_Name], [Start_Date], [End_Date], [Added_Datetime], [Project_Id]) VALUES (@Project_Task_Id, @Task_Name, @Start_Date, @End_Date, @Added_Datetime, '{projectTask.Project.Project_Id}');";
            return unitOfWork.Connection.Execute(sql, projectTask, unitOfWork.Transaction);
        }

        public List<ProjectTaskNormalised> GetAllTasksForProject(string projectId)
        {
            string sql = $@"SELECT
	                        Project_Task.Project_Task_Id, 
	                        Project_Task.Task_Name, 
	                        Project_Task.Start_Date, 
	                        Project_Task.End_Date, 
	                        Project_Task.Added_Datetime
                        FROM
	                        dbo.Project_Task
                        WHERE
	                        Project_Task.Project_Id = '{projectId}';";
            return unitOfWork.Connection.Query<ProjectTaskNormalised>(sql, null, unitOfWork.Transaction).AsList();
        }
    }
}