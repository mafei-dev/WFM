using System;

namespace WFM.Enity
{
    public class User

    {
        public User()
        {
        }


        public User(string userId)
        {
            User_Id = userId;
        }


        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string User_Id { get; set; }
        public string NIC { get; set; }
        public string Gender { get; set; }

        public int User_Type { get; set; }

        public string EMP_Id { get; set; }
    }
}