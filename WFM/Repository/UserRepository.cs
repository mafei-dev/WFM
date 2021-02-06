using System.Collections.Generic;
using Dapper;
using WFM.Database;
using WFM.Enity;
using WFM.Entity;

namespace WFM.Repository
{
    public class UserRepository : IUserRepository
    {
        private IUnitOfWork _unitOfWork;

        public UserRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<User> GetAllUsers()
        {
            string sql = $@"SELECT
								[User].First_Name, 
								[User].Last_Name, 
								[User].Address, 
								[User].User_Id, 
								[User].NIC, 
								[User].Birthday, 
								[User].Gender, 
								[User].EMP_Id, 
								[User].User_Type
							FROM
								dbo.[User]
							ORDER BY
								[User].First_Name ASC;";

            return _unitOfWork.Connection.Query<User>(sql, null, _unitOfWork.Transaction).AsList();
        }
    }
}