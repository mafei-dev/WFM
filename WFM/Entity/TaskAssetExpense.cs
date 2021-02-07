namespace WFM.Entity
{
    public class TaskAssetExpensePure
    {
        public string Task_Asset_Expense_Id { get; set; }
        public int QTY { get; set; }
    }

    public class TaskAssetExpense : TaskAssetExpensePure
    {
        public Asset Asset { get; set; }
        public TaskExpense TaskExpense { get; set; }
    }

    public class TaskAssetExpenseNormalized : TaskAssetExpensePure
    {
        public string Asset_Id { get; set; }
        public string Task_Expense_Id { get; set; }
    }
}