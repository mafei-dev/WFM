using System;
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
    }
}