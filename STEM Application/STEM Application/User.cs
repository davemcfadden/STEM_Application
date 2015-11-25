using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEM_Application
{
    class User
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
