using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace STEM_Application
{
    class BuildSqlLiteDb
    {

           // We use these three SQLite objects:
            private SQLiteConnection sqlConnection;
            private SQLiteCommand sqlCommand;
            
            public void createDatabase()
            {

                // create a new database connection:
                sqlConnection = getConnection();
 
                // open the connection:
                sqlConnection.Open();
 
                // create a new SQL command:
                sqlCommand = sqlConnection.CreateCommand();
 
                // Let the SQLiteCommand object know our SQL-Query:
                sqlCommand.CommandText = "CREATE TABLE user (id integer primary key, name varchar(100), email varchar(100), password varchar(16));";
 
                // Now lets execute the SQL ;D
                sqlCommand.ExecuteNonQuery();
 
                sqlConnection.Close();

            }


            public SQLiteConnection getConnection()
            {
                // create a new database connection:
                return new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            }
    }
}

