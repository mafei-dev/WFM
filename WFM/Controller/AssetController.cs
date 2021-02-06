using System.Collections.Generic;
using WFM.Database;
using WFM.Entity;
using WFM.Repository;

namespace WFM.Controller
{
    public class AssetController
    {
        private IAssetRepository _assetRepository;

        public List<Asset> GetAllAssets()
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _assetRepository = new AssetRepository(unitOfWork);
                    List<Asset> assets = _assetRepository.GetAllAssets();
                    unitOfWork.Commit();
                    return assets;
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