using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface IProjectIncomeRepository
    {
        decimal GetTotalProjectIncomesByMonthAndYear(string month,string year);
        int AddNewProjectIncome(ProjectIncome projectIncome);
    }
}