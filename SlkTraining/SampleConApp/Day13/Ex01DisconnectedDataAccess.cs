using System;
using System.Data; //For DataSets and DataTables
using System.Data.SqlClient;//For SqlConnection, SqlCommand and SqlDataAdapter.
using System.Configuration;

namespace SampleConApp.Day13
{
    class Ex01DisconnectedDataAccess
    {
        static string STRCONNECTION = ConfigurationManager.ConnectionStrings["myDbConnection"].ConnectionString;
        const string STRSELECT = "SELECT * FROM TBLEMPLOYEE; SELECT * FROM TBLDEPT";
        static void Main(string[] args)
        {
            //SqlConnection con = new SqlConnection(STRCONNECTION);
            //SqlCommand cmd = new SqlCommand(STRSELECT, con);
            //SqlDataAdapter ada = new SqlDataAdapter(cmd);

            SqlDataAdapter ada = new SqlDataAdapter(STRSELECT, STRCONNECTION);
            DataSet ds = new DataSet(); //Dataset is an inmemory collection of tables...

            //ada.Fill(ds, "TableOfEmployees");//Name for the table in the dataset is only conceptual. Fill is a very smart method, it opens the connection, fills the data and immediately closes the connection. If the table name is not mentioned, it would store in the first table of the dataset.
            //
            ada.Fill(ds);//if multiple select statements are there, then for each select statement a table is created in the dataset 

            Console.WriteLine("The current no of tables in our dataset is " + ds.Tables.Count);
            Console.WriteLine("The table names in our dataset are: ");
            ds.Tables[0].TableName = "EmpTable";//U can rename the table in the dataset
            ds.Tables[1].TableName = "DeptTable";

            foreach(DataTable table in ds.Tables)
            {
                Console.WriteLine(table.TableName);
            }

            //////////////////////Display the data of the EmpTable////////////////
            //Table is collection of rows and each row contains a collection of column data. 
            foreach(DataRow row in ds.Tables["EmpTable"].Rows)
            {
                string text = $"{row[1]} is from {row[2]} and earns a salary of {row[4]}. He/She can be contacted on the Email Address {row[3]}";
                Console.WriteLine(text);
            }

            //////////////////////Display the data of the DeptTable////////////////
            Console.WriteLine("\n\n\n\n\n\n\n");
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                string text = $"{row[1]} has the Dept Id as {row[0]}";
                Console.WriteLine(text);
            }

        }
    }
}

/* POINTS TO REMEMBER:
 * Use connected model for insert, delete and update as you dont hold the connection for a long time
 * Use disconnected model for select statement as more readers can read the data. 
 */
