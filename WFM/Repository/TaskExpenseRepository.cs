using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class TaskExpenseRepository : ITaskExpenseRepository
    {
        private IUnitOfWork unitOfWork;

        public TaskExpenseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int addNewTaskExpense(TaskExpense taskExpense)
        {
            string sql =
                $@"INSERT INTO [dbo].[Task_Expense]([Task_Expense_Id], [Expense_Type], [Project_Task_Id], [Cost], [Note]) VALUES (@Task_Expense_Id, @Expense_Type, '{taskExpense.ProjectTask.Project_Task_Id}', @Cost, @Note);";
            return unitOfWork.Connection.Execute(sql, taskExpense, unitOfWork.Transaction);
        }

        public List<TaskExpense> GetAllEXPsByProjectTaskId(string projectTaskId)
        {
            string sql = $@"SELECT
	                            Task_Expense.Task_Expense_Id, 
	                            Task_Expense.Expense_Type, 
	                            Task_Expense.Note, 
	                            Task_Expense.Cost
                            FROM
	                            dbo.Task_Expense
	                            INNER JOIN
	                            dbo.Project_Task
	                            ON 
		                            Task_Expense.Project_Task_Id = Project_Task.Project_Task_Id
                            WHERE
	                            Project_Task.Project_Task_Id = '{projectTaskId}';";
            return unitOfWork.Connection.Query<TaskExpense>(sql, null, unitOfWork.Transaction).AsList();
        }

        public decimal GetTotalProjectTasksExsByMonthAndYear(string month, string year)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Month", month);
            parameters.Add("@Year", year);

            string sql = @"SELECT
								SUM(Task_Expense.Cost)
							FROM
								dbo.Project
								INNER JOIN
								dbo.Project_Task
								ON 
									Project.Project_Id = Project_Task.Project_Id
								INNER JOIN
								dbo.Task_Expense
								ON 
									Project_Task.Project_Task_Id = Task_Expense.Project_Task_Id
									WHERE
								MONTH ( Task_Expense.Datetime) = @Month 
								AND YEAR ( Task_Expense.Datetime ) = @Year;";

            return unitOfWork.Connection.Query<decimal>(sql, parameters, unitOfWork.Transaction).SingleOrDefault();
        }
    }
}