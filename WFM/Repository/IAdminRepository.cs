using WFM.Models;

namespace WFM.Repository
{
    public interface IAdminRepository
    {
        int AddAdminUser(AdminUser adminUser);
    }
}