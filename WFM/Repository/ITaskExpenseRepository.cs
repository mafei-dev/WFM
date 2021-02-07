using WFM.Entity;

namespace WFM.Repository
{
    public interface ITaskExpenseRepository
    {
        int addNewTaskExpense(TaskExpense taskExpense);
    }
}