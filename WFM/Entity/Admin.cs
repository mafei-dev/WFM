using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFM.Enity;

namespace WFM.Entity
{
    public class AdminPure
    {
        public string Admin_Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        

    }

    public class Admin : AdminPure
    {
        public User user{ get; set; }
    }
}
