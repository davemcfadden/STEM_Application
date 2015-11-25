using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEM_Application
{
    class UserMapperNonDb
    {


        //declare static dictionary
        Dictionary<String, String> usersMap = new Dictionary<String, String>
            {
                {"Dave@dave.com","password"},
                {"Bob@bob.com","password"},
                {"Simon@simon.com","password"}
            };

        //declare static array
        String [] usersArray = new String[] 
        {
            "Dave@dave.com",
            "Bob@bob.com",
            "Simon@simon.com"
        }; 

        //declare static list
         private static List<String> usersList = new List<String>()
        {
                "Dave@dave.com",
                "Bob@bob.com",
                "Simon@simon.com"
        };


        public void addNewUser(User pUser)
        {
            //add to array

            int arrayLength = usersArray.Length;
            Array.Resize(ref usersArray, arrayLength + 1);

            usersArray[arrayLength] = pUser.Email;

            foreach (String i in usersArray)
            {
                Console.WriteLine("Email address is : " +  i);
            }

            //add to dictionary
            usersMap.Add(pUser.Email, pUser.Password);
            foreach (KeyValuePair<String, String> i in usersMap)
            {
                Console.WriteLine("Email address is : " + i.Key + "password is : " + i.Value);
            }

            //add to list
            usersList.Add(pUser.Email);
            foreach (String i in usersList)
            {
                Console.WriteLine("Email address is : " + i);
            }
        }


        public Boolean validateUser(User pUser)
        {
            Boolean isUserValid = false;

            Boolean bol1 = validateUserByArray(pUser);
            Boolean bol2 = validateUserByMap (pUser);
            Boolean bol3 = validateUserByList(pUser);

            if(bol1 && bol2 && bol3)
            {
                isUserValid = true;
            }

            return isUserValid;

        }

        private Boolean validateUserByArray(User pUser)
        {
            Boolean valid = false;

            foreach (String i in usersArray)
            {
                if (i.Equals(pUser.Email, StringComparison.InvariantCultureIgnoreCase))
                {
                    valid = true;
                    break;
                }
            }
            return valid;
        }


        private Boolean validateUserByMap(User pUser)
        {
            Boolean valid = false;

            foreach (KeyValuePair<String, String> i in usersMap)
            {
                if (i.Key.Equals(pUser.Email, StringComparison.InvariantCultureIgnoreCase) && i.Value.Equals(pUser.Password))
                {
                    valid = true;
                    break;
                }
            }
            return valid;

        }


        private Boolean validateUserByList(User pUser)
        {
            Boolean valid = false;

            foreach (String i in usersList)
            {
                if (i.Equals(pUser.Email, StringComparison.InvariantCultureIgnoreCase))
                {
                    valid = true;
                    break;
                }
            }
            return valid;

        }

    }
}
