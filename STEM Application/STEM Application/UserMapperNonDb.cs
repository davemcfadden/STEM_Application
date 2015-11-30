using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STEM_Application
{
    class UserMapperNonDb
    {


        //declare static dictionary
        Dictionary<string, string> usersMap = new Dictionary<string, string>
            {
                {"dave@dave.com","password"},
                {"bob@bob.com","password"},
                {"simon@simon.com","password"}
            };

        //declare static array
        string [] usersArray = new string[] 
        {
            "dave@dave.com",
            "bob@bob.com",
            "simon@simon.com"
        }; 

        //declare static list
         private static List<string> usersList = new List<string>()
        {
                "dave@dave.com",
                "bob@bob.com",
                "simon@simon.com"
        };


        public void AddNewUser(User pUser)
        {
            //add to array

            int arrayLength = usersArray.Length;
            Array.Resize(ref usersArray, arrayLength + 1);

            usersArray[arrayLength] = pUser.Email;

            foreach (string i in usersArray)
            {
                Console.WriteLine("Array email address is : " +  i);
            }

            //add to dictionary
            usersMap.Add(pUser.Email, pUser.Password);
            foreach (KeyValuePair<string, string> i in usersMap)
            {
                Console.WriteLine("Dictionary email address is : " + i.Key + "password is : " + i.Value);
            }

            //add to list
            usersList.Add(pUser.Email);
            foreach (string i in usersList)
            {
                Console.WriteLine("List email address is : " + i);
            }
        }


        public bool ValidateUser(User pUser)
        {
            bool isUserValid = false;

            bool bol1 = ValidateUserByArray(pUser);
            bool bol2 = ValidateUserByMap (pUser);
            bool bol3 = ValidateUserByList(pUser);

            if(bol1 && bol2 && bol3)
            {
                isUserValid = true;
            }

            return isUserValid;

        }

        private bool ValidateUserByArray(User pUser)
        {
            bool valid = false;

            foreach (string i in usersArray)
            {
                if (i.Equals(pUser.Email))
                {
                    valid = true;
                    break;
                }
            }
            return valid;
        }


        private bool ValidateUserByMap(User pUser)
        {
            bool valid = false;

            foreach (KeyValuePair<string, string> i in usersMap)
            {
                if (i.Key.Equals(pUser.Email) && i.Value.Equals(pUser.Password))
                {
                    valid = true;
                    break;
                }
            }
            return valid;

        }


        private bool ValidateUserByList(User pUser)
        {
            bool valid = false;

            foreach (string i in usersList)
            {
                if (i.Equals(pUser.Email))
                {
                    valid = true;
                    break;
                }
            }
            return valid;

        }

    }
}
