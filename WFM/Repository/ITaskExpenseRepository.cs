using System;
using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface ITaskExpenseRepository
    {
        int addNewTaskExpense(TaskExpense taskExpense);
        List<TaskExpense> GetAllEXPsByProjectTaskId(string projectTaskId);

        decimal GetTotalProjectTasksExsByMonthAndYear(string month, string year);
        List<TaskExpenseView> GetAllTaskExpensesByRange(DateTime from, DateTime to);
    }
}