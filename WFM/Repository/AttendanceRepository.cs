using System;
using System.Collections.Generic;
using Dapper;
using WFM.Database;
using WFM.Entity;

namespace WFM.Repository
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private IUnitOfWork _unitOfWork;

        public AttendanceRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int AddAttendance(Attendance attendance)
        {
            Console.WriteLine("attendance {0}",attendance.ToString());
            string sql =
                $@"INSERT INTO [dbo].[Attendance](
                   [Attendance_Id], 
                   [Datetime], 
                   [Type], 
                   [Attend_Date_Id]) 
                    VALUES (
                    @Attendance_Id, 
                    @Datetime, 
                    @Type, '{attendance.AttendDate.Attend_Date_Id}');";
                    
            return _unitOfWork.Connection.Execute(sql, attendance, _unitOfWork.Transaction);
        }

        public List<AttendanceView> GetAllAttendanceByAttendDateAndUser(DateTime date,string userId)
        {
	        DynamicParameters parameters = new DynamicParameters();
	        parameters.Add("@Attend_Date", date.Date);
	        parameters.Add("@User_Id", userId);
	        
            string sql =
               $@"SELECT
					Attendance.Attendance_Id, 
					Attendance.Type,
					Attendance.Datetime
				FROM
					dbo.Attendance
					INNER JOIN
					dbo.Attend_Date
					ON 
						Attendance.Attend_Date_Id = Attend_Date.Attend_Date_Id
					INNER JOIN
					dbo.[User]
					ON 
						Attend_Date.User_Id = [User].User_Id
				WHERE
					[User].User_Id = @User_Id AND
					Attend_Date.[Date] = @Attend_Date
                ORDER BY
	            Attendance.Datetime ASC;";

            return _unitOfWork.Connection.Query<AttendanceView>(sql, parameters, _unitOfWork.Transaction).AsList();

        }
    }
}