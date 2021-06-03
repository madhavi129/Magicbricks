using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MClib
{
    public class User
    {
        string pwd;
        public string UserName { get; set; }
        public string Password
        {
            get
            {
                return this.pwd;
            }
            set
            {
                if (value.Length > 8)
                    this.pwd = value;
                else
                    this.pwd = null;
            }
        }
        public long PhoneNumber { get; set; }
    }
}
