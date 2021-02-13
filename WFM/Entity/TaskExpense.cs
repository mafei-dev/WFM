using System;

namespace WFM.Entity
{
    public class TaskExpensePure
    {
        public string Task_Expense_Id { get; set; }
        public string Expense_Type { get; set; }
        public Decimal Cost { get; set; }
        public string Note { get; set; }
        public DateTime Datetime { get; set; }
    }

    public class TaskExpense : TaskExpensePure
    {
        public ProjectTask ProjectTask { get; set; }
    }

    public class TaskExpenseNormalized : TaskExpensePure
    {
        public string Project_Task_Id { get; set; }
    }

    public class TaskExpenseView : TaskExpensePure
    {
        public string Task_Name { get; set; }
        public string Project_Name { get; set; }
    }

}