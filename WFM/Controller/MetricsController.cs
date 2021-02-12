using System;
using WFM.Database;
using WFM.Models;
using WFM.Repository;

namespace WFM.Controller
{
    public class MetricsController
    {
        private IProjectRepository _projectRepository;
        private IEmployeeRepo _employeeRepo;
        private IAssetRepository _assetRepository;
        private IProjectIncomeRepository _projectIncomeRepository;
        private ITaskExpenseRepository _taskExpenseRepository;

        public TotalDetail GetTotalDetails()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _projectRepository = new ProjectRepository(unitOfWork);
                    _employeeRepo = new EmployeeRepo(unitOfWork);
                    _assetRepository = new AssetRepository(unitOfWork);
                    _taskExpenseRepository = new TaskExpenseRepository(unitOfWork);
                    _projectIncomeRepository = new ProjectIncomeRepository(unitOfWork);

                    TotalDetail totalDetail = new TotalDetail();
                    totalDetail.TotalProject = _projectRepository.GetTotalProjects();
                    totalDetail.TotalEmployees = _employeeRepo.GetTotalEmployees();
                    totalDetail.TotalAssets = _assetRepository.GetTotalAssets();
                    totalDetail.TotalIncome =
                        _projectIncomeRepository.GetTotalProjectIncomesByMonthAndYear(
                            DateTime.Now.Month.ToString(),
                            DateTime.Now.Year.ToString()
                        );

                    totalDetail.TotalExpenses = _taskExpenseRepository.GetTotalProjectTasksExsByMonthAndYear(
                        DateTime.Now.Month.ToString(),
                        DateTime.Now.Year.ToString()
                    );
                    
                    unitOfWork.Commit();
                    return totalDetail;
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }
    }
}