using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEM_Application
{
    class userServiceImpl: userService 
    {
        public userMapper mapper = new userMapper();

        public UserMapperNonDb mapperNonDb = new UserMapperNonDb();

        public User addNewUser(User pUser)
        {
            //Uncomment the following for SQLLite Database,
           //mapper.addNewUser(pUser);

            mapperNonDb.addNewUser(pUser);

            return pUser;
        }


        public Boolean validateUser(User pUser)
        {
            Boolean isValid = false;
            
            //Uncomment the following for SQLLite Database, TODO not yet finished
            //int valid =  mapper.validateUser(pUser);
            //if(valid >=1)
            //{
            //  isValid = true;
            //}

            isValid = mapperNonDb.validateUser(pUser);
            return isValid;
        }

    }
}
