using System;
using System.Collections.Generic;
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


        public AttendDate CheckDateForEmployee(string empId,DateTime dateTime)
        {

            Console.WriteLine("EMPId {0}", empId);
            Console.WriteLine("Attend_Date {0}", dateTime.Date);
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@EMPId", empId);
            parameters.Add("@Attend_Date", dateTime.Date);
            string sql = $@"SELECT
	                            Attend_Date.Attend_Date_Id, 
	                            Attend_Date.[Date], 
	                            Attend_Date.Type, 
	                            Attend_Date.User_Id
                            FROM
	                            dbo.Attend_Date
                            WHERE
	                            Attend_Date.User_Id = @EMPId And Attend_Date.[Date] = @Attend_Date;";
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

        public List<AttendDateView> AddAttendDateForDate(DateTime attendDate)
        {
            /*DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Attend_Date", attendDate);
            string sql = $@"SELECT
                                [User].First_Name, 
                                [User].Last_Name, 
                                [User].Address, 
                                [User].User_Id, 
                                [User].NIC, 
                                [User].Gender, 
                                [User].EMP_Id, 
                                Attend_Date.Attend_Date_Id, 
                                Attend_Date.[Date]  AS Attend_Date, 
                                Attend_Date.Type, 
                                [User].Birthday
                            FROM
                                dbo.[User]
                                INNER JOIN
                                dbo.Attend_Date
                                ON 
                                    [User].User_Id = Attend_Date.User_Id
                            WHERE
                                Attend_Date.[Date] = @attendDate;";
            return _unitOfWork.Connection.Query<AttendDateView>(sql, parameters, _unitOfWork.Transaction).ToList();*/

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Attend_Date", attendDate);
            string sql = $@"SELECT
					[User].First_Name, 
					[User].Last_Name, 
					[User].Address, 
					[User].User_Id, 
					[User].NIC, 
					[User].Gender, 
					[User].EMP_Id, 
					Attend_Date.Attend_Date_Id AS Attend_Date, 
					Attend_Date.[Date], 
					Attend_Date.Type, 
					[User].Birthday
				FROM
					dbo.[User]
					INNER JOIN
					dbo.Attend_Date
					ON 
						[User].User_Id = Attend_Date.User_Id
				WHERE
					Attend_Date.[Date] = @Attend_Date;";

            return _unitOfWork.Connection.Query<AttendDateView>(sql, parameters, _unitOfWork.Transaction).AsList();
        }
    }
}