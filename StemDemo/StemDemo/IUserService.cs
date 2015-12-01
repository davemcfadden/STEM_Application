using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StemDemo
{
   
        interface IUserService
        {

            User AddNewUser(User pUser);

            Boolean ValidateUser(User pUSer);

        }
}

