using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEM_Application
{
    class UserService: IUserService 
    {
        public UserMapper mapper = new UserMapper();

        public UserMapperNonDb mapperNonDb = new UserMapperNonDb();

        public User AddNewUser(User pUser)
        {
            //Uncomment the following for SQLLite Database,
           //mapper.addNewUser(pUser);

            mapperNonDb.AddNewUser(pUser);

            return pUser;
        }


        public bool ValidateUser(User pUser)
        {
            bool isValid = false;
            
            //Uncomment the following for SQLLite Database, TODO not yet finished
            //int valid =  mapper.validateUser(pUser);
            //if(valid >=1)
            //{
            //  isValid = true;
            //}

            isValid = mapperNonDb.ValidateUser(pUser);
            return isValid;
        }

    }
}
