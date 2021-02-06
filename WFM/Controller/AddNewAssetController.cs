using System;
using WFM.Database;
using WFM.Entity;
using WFM.Repository;

namespace WFM.Controller
{
    public class AddNewAssetController
    {
        private IAssetRepository _assetRepository;

        public bool AddNewAsset(Asset asset)
        {
            using (DalSession dalSession = new DalSession())
            {
                UnitOfWork unitOfWork = dalSession.UnitOfWork();
                unitOfWork.Begin();
                try
                {
                    _assetRepository = new AssetRepository(unitOfWork);
                    asset.Asset_Id = Guid.NewGuid().ToString();
                    if (_assetRepository.AddNewAsset(asset) == 1)
                    {
                        unitOfWork.Commit();
                        return true;
                    }
                    else
                    {
                        unitOfWork.Rollback();
                        return false;
                    }
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
