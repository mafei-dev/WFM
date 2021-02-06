using System;
using System.Collections.Generic;
using WFM.Enity;

namespace WFM.Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}