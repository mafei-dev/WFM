using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class ProjectAssetRepository : IProjectAssetRepository
    {
        private IUnitOfWork _unitOfWork;

        public ProjectAssetRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int AssignAssetToProject(ProjectAsset projectAsset)
        {
            string sql =
                $@"INSERT INTO [dbo].[Project_Asset]([Project_Asset_Id], [Note], [Added_Datetime], [Project_Id], [Asset_Id]) VALUES (@Project_Asset_Id, @Note, @Added_Datetime, '{projectAsset.Project.Project_Id}', '{projectAsset.Asset.Asset_Id}');";
            return _unitOfWork.Connection.Execute(sql, projectAsset, _unitOfWork.Transaction);
        }
    }
}