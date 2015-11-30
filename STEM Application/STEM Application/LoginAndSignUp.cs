using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace STEM_Application{
    public partial class LoginAndSignUp : Form {

        private List<String> errorMessages= new  List<String>();

        private String loginAttemptsFile = "C:\\Users\\n0237982\\Documents\\STEM\\loginAttempts.txt";

       

        public LoginAndSignUp()   {
            InitializeComponent();
            //BuildSqlLiteDb build = new BuildSqlLiteDb();
            //build.createDatabase();
        }

        private void userSelectsSignUp(object sender, EventArgs e)
        {
            User currentUser = createSignUpUser();
            if (validate(currentUser))
            {
                userService signUpService = new userServiceImpl() ;
                signUpService.addNewUser(currentUser);
                this.Hide();
                Home home = new Home();
                home.Show();
            }
           
        }

        private void userSelectsClearFields(object sender, EventArgs e)
        {
            name_input.Clear();
            email_input.Clear();
            password_input.Clear();
            confirmpassword_input.Clear();
            validationErrors.Clear();

        }


        private void userSelectsLogin(object sender, EventArgs e)
        {
            User currentUser = createLoginUser();
            userService loginService = new userServiceImpl();

            Boolean validUser = loginService.validateUser(currentUser);

            if (validUser)
            {
                resetLoginAttempts();
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                addLoginAttempts(readLoginAttempts());
                this.loginValidation.Items.Clear();
                this.loginValidation.Items.Add("Email or password is incorrect");
                Console.WriteLine("Logging error : Email or password is incorrect");
            }
         

        }


        private void formClosingEvent(object sender, FormClosedEventArgs e)
        {
            resetLoginAttempts();
        }


        private int readLoginAttempts()
        {
            String line;
            int attempts = 0;
            StreamReader sr;
            try
            {
                sr = new StreamReader(loginAttemptsFile);
              
                //Read the first line of text
                line =  sr.ReadLine();

                //Continue to read until you reach end of file
              /*  while (line != null)
                {
                    //Read the next line
                    line = sr.ReadLine();
                }
               * */

                Console.WriteLine("Number of attempts in file : " + line);
                if(line != null)
                {
                //convert to int
                attempts = Int32.Parse(line);
                }
              

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when reading file : " + e.Message);
            }

            return attempts;
        }


        private void addLoginAttempts(int attempts)
        {
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(loginAttemptsFile);
            
            //add to the attempts file
            attempts += 1;

            Console.WriteLine("Updated login attempts : " + attempts);
            file.WriteLine(attempts.ToString());

            file.Close();

        }


        private void resetLoginAttempts()
        {
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(loginAttemptsFile);

            Console.WriteLine("Resetting login attempts");
            file.WriteLine(0);

            file.Close();

        }
    

        private User createSignUpUser()
        {
            User currentUser = new User();
            currentUser = new User();
            currentUser.Name = name_input.Text;
            Console.WriteLine("Name is " + currentUser.Name);
            currentUser.Email = email_input.Text;
            Console.WriteLine("Email is " + currentUser.Email);
            currentUser.Password = password_input.Text;
            Console.WriteLine("Password is " + currentUser.Password);

            return currentUser;
        }


        private User createLoginUser()
        {
            User currentUser = new User();
            currentUser.Email = loginEmail_Input.Text;
            Console.WriteLine("Email is " + currentUser.Email);
            currentUser.Password = loginPassword_Input.Text;
            Console.WriteLine("Password is " + currentUser.Password);

            return currentUser;
        }


        private Boolean validate(User currentUser)
        {
            Boolean isValid = true;

            if( !validateEmailFormat(currentUser) || !doPasswordsMatch() )
            {
                foreach(String i in errorMessages)
                {
                    validationErrors.View = View.List;
                    this.validationErrors.Items.Add(i);
                }
                isValid = false;
            }

            return isValid;
        }
      

        private Boolean doPasswordsMatch()
        {
            Boolean returnValue = true;
            if (!password_input.Text.Equals(confirmpassword_input.Text))
            {
                errorMessages.Add("Passwords do not match");
                Console.WriteLine("Logging error : Password do not match");
                returnValue = false;
            }

            return returnValue;
        }



        private Boolean validateEmailFormat(User pUser)
        {
            Boolean isValid = false;

            string email = pUser.Email;
            System.Text.RegularExpressions.Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Console.Write(email + " is valid");
                isValid = true;
            }
            else
            {
                Console.Write(email + " is invalid");
                errorMessages.Add("Email format is incorrect");
            }

            return isValid;
        }

      
       
       

    }
}
