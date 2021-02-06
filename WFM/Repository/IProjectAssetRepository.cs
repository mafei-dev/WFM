using WFM.Entity;

namespace WFM.Repository
{
    public interface IProjectAssetRepository
    {
        int AssignAssetToProject(ProjectAsset projectAsset);
    }
}