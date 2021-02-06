using Dapper;
using WFM.Database;
using WFM.Models;

namespace WFM.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private IUnitOfWork unitOfWork;

        public AdminRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public int AddAdminUser(AdminUser adminUser)
        {
            string sql =
                $@"INSERT INTO [dbo].[User]([First_Name], [Last_Name], [Address], [User_Id], [NIC], [Gender], [Birthday], [User_Type]) 
                            VALUES (@First_Name, @Last_Name, @Address, @User_Id, @NIC, @Gender , @Birthday, @User_Type);";
            return unitOfWork.Connection.Execute(sql, adminUser, unitOfWork.Transaction);
        }
    }
}