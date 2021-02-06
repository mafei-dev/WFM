using System;
using System.Collections.Generic;
using WFM.Enity;
using WFM.Properties;

namespace WFM.Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        List<User> SearchUserByName(string name, StaticResource.UseType userType);
    }
}