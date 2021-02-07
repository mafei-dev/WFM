namespace WFM.Entity
{
    public class TaskOtherExpensePure
    {
        public string Task_Other_Expense_Id { get; set; }
        public string Expense_Name { get; set; }
    }

    public class TaskOtherExpense : TaskOtherExpensePure
    {
        public TaskExpense TaskExpense { get; set; }
    }

    public class TaskOtherExpenseNormalized : TaskOtherExpensePure
    {
        public string Task_Expense_Id { get; set; }
    }
}