using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StemDemo
{
    public partial class Form1 : Form
    {

        private string loginAttemptsFile = "C:\\Users\\n0237982\\Documents\\STEM\\loginAttempts.txt";


        public Form1()
        {
            InitializeComponent();
        }


        private void login_Click(object sender, EventArgs e)
        {
         
            User currentUser = CreateLoginUser();
            IUserService loginService = new UserService();
            bool validUser = loginService.ValidateUser(currentUser);


            if (validUser)
            {
                ResetLoginAttempts();
                this.Hide();
                Home home = new Home();
                home.Show();
            }
            else
            {
                AddLoginAttempts(ReadLoginAttempts());
                Console.WriteLine("Logging error : Email or password is incorrect");
            }
           
        }

        private User CreateLoginUser()
        {
            User currentUser = new User();


            currentUser.Email = emailInput.Text;
            Console.WriteLine("Email is " + currentUser.Email);
            currentUser.Password = passwordInput.Text;
            Console.WriteLine("Password is " + currentUser.Password);

            return currentUser;
        }





        private int ReadLoginAttempts()
        {
            string line;
            int attempts = 0;
            StreamReader sr;
            try
            {
                sr = new StreamReader(loginAttemptsFile);

                //Read the first line of text
                line = sr.ReadLine();

                //Continue to read until you reach end of file
                /*  while (line != null)
                  {
                      //Read the next line
                      line = sr.ReadLine();
                  }
                 * */

                Console.WriteLine("Number of attempts in file : " + line);
                if (line != null)
                {
                    //convert to int
                    int testNum;
                    int.TryParse(line, out testNum);
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


        private void AddLoginAttempts(int attempts)
        {
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(loginAttemptsFile);

            //add to the attempts file
            attempts += 1;

            Console.WriteLine("Updated login attempts : " + attempts);
            file.WriteLine(attempts);

            file.Close();

        }


        private void ResetLoginAttempts()
        {
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(loginAttemptsFile);

            Console.WriteLine("Resetting login attempts");
            file.WriteLine(0);

            file.Close();

        }

     
    }
}
