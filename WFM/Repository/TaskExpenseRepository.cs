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
    }
}