using WFM.Enity;

namespace WFM.Entity
{
    public class TaskEmpExpensePure
    {
        public string Task_Emp_Expense_Id { get; set; }
    }

    public class TaskEmpExpense : TaskEmpExpensePure
    {
        public TaskExpense TaskExpense { get; set; }
        public User User { get; set; }
    }

    public class TaskEmpExpenseNormalized : TaskEmpExpensePure
    {
        public string Task_Expense_Id { get; set; }
        public string User_Id { get; set; }
    }
}