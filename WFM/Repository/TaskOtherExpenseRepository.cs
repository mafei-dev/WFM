using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class TaskOtherExpenseRepository : ITaskOtherExpenseRepository
    {
        private IUnitOfWork unitOfWork;

        public TaskOtherExpenseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int addNewTaskOtherExpense(TaskOtherExpense taskOtherExpense)
        {
            string sql =
                $@"INSERT INTO [dbo].[Task_Other_Expense]([Task_Other_Expense_Id], [Expense_Name], [Task_Expense_Id]) VALUES (@Task_Other_Expense_Id, @Expense_Name, '{taskOtherExpense.TaskExpense.Task_Expense_Id}');";
            return unitOfWork.Connection.Execute(sql, taskOtherExpense, unitOfWork.Transaction);
        }
    }
}