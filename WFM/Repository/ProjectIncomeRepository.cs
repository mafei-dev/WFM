using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class ProjectIncomeRepository : IProjectIncomeRepository
    {
        private IUnitOfWork unitOfWork;

        public ProjectIncomeRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddNewProjectIncome(ProjectIncome projectIncome)
        {
            string sql =
                $@"INSERT INTO [dbo].[Project_Income]([Project_Income_Id], [Project_Id], [Note], [Amount], [In_Datetime]) VALUES (@Project_Income_Id, '{projectIncome.Project.Project_Id}', @Note, @Amount, @In_Datetime);";
            return unitOfWork.Connection.Execute(sql, projectIncome, unitOfWork.Transaction);
        }

        public decimal GetTotalProjectIncomesByMonthAndYear(string month,string year)
        {
	        DynamicParameters parameters = new DynamicParameters();
	        parameters.Add("@Month", month);
	        parameters.Add("@Year", year);

	        string sql = @"SELECT SUM
							( Project_Income.amount ) 
						FROM
							dbo.Project_Income
							INNER JOIN dbo.Project ON Project_Income.Project_Id = Project.Project_Id 
						WHERE
							MONTH ( Project_Income.In_Datetime ) = @Month 
							AND YEAR ( Project_Income.In_Datetime ) = @Year;";

	        return unitOfWork.Connection.Query<decimal>(sql, parameters, unitOfWork.Transaction).SingleOrDefault();
        }
        
        
    }
}