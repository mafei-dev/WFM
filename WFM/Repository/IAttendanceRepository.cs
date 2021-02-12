using System;
using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface IAttendanceRepository
    {
        int AddAttendance(Attendance attendance);
        List<AttendanceView> GetAllAttendanceByAttendDateAndUser(DateTime date,string userId);
    }
}