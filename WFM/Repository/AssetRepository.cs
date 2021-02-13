using System.Collections.Generic;
using System.Linq;
using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class AssetRepository : IAssetRepository
    {
        private IUnitOfWork unitOfWork;


        public AssetRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddNewAsset(Asset asset)
        {
            string sql =
                $@"INSERT INTO [dbo].[Asset]([Asset_Id], [Name], [Note], [QTY],[Category]) VALUES (@Asset_Id, @Name, @Note, @QTY,@Category);";
            return unitOfWork.Connection.Execute(sql, asset, unitOfWork.Transaction);
        }

        public List<Asset> GetAllAssets()
        {
            string sql = $@"SELECT
	                        Asset.Asset_Id, 
	                        Asset.Name, 
	                        Asset.Note, 
	                        Asset.QTY,
	                        Asset.Category
                        FROM
	                        dbo.Asset;";
            return unitOfWork.Connection.Query<Asset>(sql, null, unitOfWork.Transaction).ToList();
        }

        public int GetTotalAssets()
        {
            string sql = $@"SELECT
	                            COUNT(Asset.Asset_Id)
                            FROM
	                            dbo.Asset";
            return unitOfWork.Connection.Query<int>(sql, null, unitOfWork.Transaction).SingleOrDefault();
        }
    }
}