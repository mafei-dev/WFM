using WFM.Entity;

namespace WFM.Repository
{
    public interface IAttendanceRepository
    {
        int AddAttendance(Attendance attendance);
    }
}