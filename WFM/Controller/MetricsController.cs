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

                    TotalDetail totalDetail = new TotalDetail();
                    totalDetail.TotalProject = _projectRepository.GetTotalProjects();
                    totalDetail.TotalEmployees = _employeeRepo.GetTotalEmployees();
                    totalDetail.TotalAssets = _assetRepository.GetTotalAssets();

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