using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class TaskEmpExpenseRepository : ITaskEmpExpenseRepository
    {
        private IUnitOfWork unitOfWork;

        public TaskEmpExpenseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int addNewTaskEmpExpense(TaskEmpExpense taskEmpExpense)
        {
            string sql =
                $@"INSERT INTO [dbo].[Task_Emp_Expense]([Task_Emp_Expense_Id], [Task_Expense_Id], [User_Id]) VALUES (@Task_Emp_Expense_Id, '{taskEmpExpense.TaskExpense.Task_Expense_Id}', '{taskEmpExpense.User.User_Id}');";
            return unitOfWork.Connection.Execute(sql, taskEmpExpense, unitOfWork.Transaction);
        }
    }
}