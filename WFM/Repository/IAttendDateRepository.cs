using System;
using System.Collections.Generic;
using WFM.Entity;

namespace WFM.Repository
{
    public interface IAttendDateRepository
    {
        AttendDate CheckDateForEmployee(string empId,DateTime dateTime);
        int AddAttendDateForUser(AttendDate attendDate);
        List<AttendDateView> AddAttendDateForDate(DateTime attendDate);
    }
}