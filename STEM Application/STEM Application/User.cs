using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEM_Application
{
    class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string password;

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
