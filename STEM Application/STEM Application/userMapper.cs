using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace STEM_Application
{
    class UserMapper
    {

        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private SQLiteDataReader sqlReader;
            

        public User AddNewUser(User pUser)
        {
            BuildSqlLiteDb sql = new BuildSqlLiteDb();
            // create a new database connection:
            sqlConnection = sql.getConnection();
            sqlConnection.Open();

            sqlCommand = sqlConnection.CreateCommand();
                
            sqlCommand.CommandText = "INSERT INTO USER (name,email,password) VALUES(@name, @email, @password)";
            	
            sqlCommand.Parameters.Add(new SQLiteParameter("@name", pUser.Name));
            sqlCommand.Parameters.Add(new SQLiteParameter("@email", pUser.Email));
            sqlCommand.Parameters.Add(new SQLiteParameter("@password", pUser.Password));

            sqlCommand.ExecuteNonQuery();
            Console.Write("User inserted : " + pUser.toString());
            sqlConnection.Close();

            return pUser;
        }



        public int ValidateUser(User pUser)
        {
            BuildSqlLiteDb sql = new BuildSqlLiteDb();
            // create a new database connection:
            sqlConnection = sql.getConnection();
            sqlConnection.Open();

            sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = "select count(1) from user where email = @email and password = @password";

            sqlCommand.Parameters.Add(new SQLiteParameter("@email", pUser.Email));
            sqlCommand.Parameters.Add(new SQLiteParameter("@password", pUser.Password));
            sqlReader = sqlCommand.ExecuteReader();

            int valid = 1;

            //TODO - read results

         

            sqlConnection.Close();

            return valid;
        }





    }
}