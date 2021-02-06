using WFM.Entity;

namespace WFM.Repository
{
    public interface IAttendDateRepository
    {
        AttendDate CheckDateForEmployee(string empId);
        int AddAttendDateForUser(AttendDate attendDate);
    }
}