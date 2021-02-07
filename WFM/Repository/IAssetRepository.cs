using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface IAssetRepository
    {
        int AddNewAsset(Asset asset);
        List<Asset> GetAllAssets();
        int GetTotalAssets();
    }
}