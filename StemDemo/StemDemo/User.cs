using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StemDemo
{
    class User
    {
        private string name;
         private string email;
        private string password;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
       

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
      

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string toString()
        {
            return name + email + password;
        }
    }
}
