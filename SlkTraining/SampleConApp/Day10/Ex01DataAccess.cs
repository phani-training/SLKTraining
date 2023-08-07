using System;
using System.Data;
using System.Data.SqlClient;

//From our app, we will connect to the SQL server database using ADO.NET Classes.
//For other databases, please refer the Documentation of .NET Framework. 

namespace SampleConApp.Day10
{
    class Ex01DataAccess
    {
        const string CONNECTIONSTRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=SLKDatabase;Integrated Security=True";
        const string GETALL = "SELECT * FROM EMPTABLE";
        static void Main(string[] args)
        {
            //readRecords();
            //insertRecord(116, "Jullian", "Jullian@gmail.com", 987969896, 50000);
        }

        private static void insertRecord(int id, string name, string email, long phone, int salary)
        {
            string insertStatement = $"Insert into EmpTable values({id}, '{name}', '{email}', {phone}, {salary})";
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected == 1)
                {
                    Console.WriteLine("Employee inserted successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void readRecords()
        {
            SqlConnection con = new SqlConnection(CONNECTIONSTRING);
            //con.ConnectionString = CONNECTIONSTRING;

            SqlCommand cmd = new SqlCommand(GETALL, con);
            //cmd.Connection = con;
            //cmd.CommandText = GETALL;
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["empName"]);
                    Console.WriteLine(reader[2]);
                    Console.WriteLine("-----------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
