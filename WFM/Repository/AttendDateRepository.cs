using System.Linq;
using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class AttendDateRepository : IAttendDateRepository
    {
        private IUnitOfWork _unitOfWork;

        public AttendDateRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public AttendDate CheckDateForEmployee(string empId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EMPId", empId);
            string sql = $@"SELECT
	                            Attend_Date.Attend_Date_Id, 
	                            Attend_Date.[Date], 
	                            Attend_Date.Type, 
	                            Attend_Date.User_Id
                            FROM
	                            dbo.Attend_Date
                            WHERE
	                            Attend_Date.User_Id = @EMPId";
            return _unitOfWork.Connection.Query<AttendDate>(sql, parameters, _unitOfWork.Transaction).SingleOrDefault();
        }

        public int AddAttendDateForUser(AttendDate attendDate)
        {
            string sql =
                $@"INSERT INTO [dbo].[Attend_Date]
                    ([Attend_Date_Id], [Date], [Type], [User_Id]) 
                    VALUES (@Attend_Date_Id, @Date, @Type, '{attendDate.User.User_Id}');";
            return _unitOfWork.Connection.Execute(sql, attendDate, _unitOfWork.Transaction);
        }
    }
}