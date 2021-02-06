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
                $@"INSERT INTO [dbo].[Asset]([Asset_Id], [Name], [Note], [QTY]) VALUES (@Asset_Id, @Name, @Note, @QTY);";
            return unitOfWork.Connection.Execute(sql, asset, unitOfWork.Transaction);
        }
    }
}