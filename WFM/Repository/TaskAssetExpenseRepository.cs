using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class TaskAssetExpenseRepository : ITaskAssetExpenseRepository
    {
        private IUnitOfWork unitOfWork;

        public TaskAssetExpenseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int addNewTaskAssetExpense(TaskAssetExpense taskAssetExpense)
        {
            string sql =
                $@"INSERT INTO [dbo].[Task_Asset_Expense]([Task_Asset_Expense_Id], [Asset_Id], [QTY], [Task_Expense_Id]) VALUES (@Task_Asset_Expense_Id, '{taskAssetExpense.Asset.Asset_Id}', @QTY, '{taskAssetExpense.TaskExpense.Task_Expense_Id}');";
            return unitOfWork.Connection.Execute(sql, taskAssetExpense, unitOfWork.Transaction);
        }
    }
}