using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClib
{
    public class Valid
    {
        private User user { get; set; }

        public bool Login(string userName, string pwd)
        {
            if (user != null)
            {
                if (user.UserName == userName && user.Password == pwd)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public bool Signin(string userName, string pwd, long number)
        {
            user = new User();
            user.UserName = userName;
            user.Password = pwd;
            user.PhoneNumber = number;
            return true;
        }

        public bool IsValidPassword(string password)
        {
            if (password.Length < 8)
                return false;
            else
                return true;
        }
    }
}