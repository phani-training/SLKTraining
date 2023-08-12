using SampleConApp.Day12.DataLib;
using SampleConApp.Day12.DataModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
namespace SampleConApp.Day12
{
    //UserInput -> Employee -> DataLib->API -> Database
    //UserQuery <- Employee <- Data <-Database <- API <- DataLib
    namespace DataModels
    {
        public class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string EmpAddres { get; set; }
            public string EmailAddress { get; set; }
            public int EmpSalary { get; set; }
            public int? DeptId { get; set; }
        }

        public class Dept
        {
            public int DeptId { get; set; }
            public string DeptName { get; set; }
        }
    }
    namespace DataLib
    {


        [Serializable]
        public class EmployeeDbException : Exception
        {
            public EmployeeDbException() { }
            public EmployeeDbException(string message) : base(message) { }
            public EmployeeDbException(string message, Exception inner) : base(message, inner) { }
            protected EmployeeDbException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
        //CRUD opertions.
        public interface IDataAccess
        {
            List<Employee> GetAllEmployees();//Reading
            void AddNewEmployee(Employee emp);//Creating
            void UpdateEmployee(int id, Employee emp);//Updating
            void DeleteEmployee(int id);//Deleting

        }
        //Add the reference of the Dll System.Configuration before writing the code
        public class ConnectedDataAccess : IDataAccess
        {
            static string strConnection = ConfigurationManager.ConnectionStrings["myDbConnection"].ConnectionString;
            const string STRGETALL = "Select * from tblEmployee";
            const string STRINSERT = "Insert into tblEmployee values(@name, @address, @email,@salary, @dept)";
            const string STRUPDATE = "Update tblEmployee set empName = @name, empAddress = @address, emailId = @email, empSalary = @salary, deptId = @dept where empId = @id";

            public void AddNewEmployee(Employee emp)
            {
                var connection = new SqlConnection(strConnection);
                var command = new SqlCommand(STRINSERT, connection);
                command.Parameters.AddWithValue("@name", emp.EmpName);
                command.Parameters.AddWithValue("@address", emp.EmpAddres);
                command.Parameters.AddWithValue("@email", emp.EmailAddress);
                command.Parameters.AddWithValue("@salary", emp.EmpSalary);
                command.Parameters.AddWithValue("@dept", emp.DeptId);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch(SqlException ex)
                {
                    throw new EmployeeDbException("Insertion failed", ex);
                }
                finally
                {
                    connection.Close();
                }
            }

            public void DeleteEmployee(int id)
            {
                throw new System.NotImplementedException();
            }

            public List<Employee> GetAllEmployees()
            {
                List<Employee> empList = new List<Employee>();
                var connection = new SqlConnection(strConnection);
                var command = new SqlCommand(STRGETALL, connection);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())//returns false means, no more rows to read....
                    {
                        var emp = new Employee();
                        emp.EmpId = Convert.ToInt32(reader[0]);
                        emp.EmpName = reader["empName"].ToString();
                        emp.EmpAddres = reader["empAddress"].ToString();
                        emp.EmailAddress = reader[3].ToString();
                        emp.EmpSalary = Convert.ToInt32(reader[4]);
                        var obj = reader["deptId"];
                        if(obj == null || obj == DBNull.Value)
                        {
                            emp.DeptId = 0;
                        }else
                            emp.DeptId = Convert.ToInt32(reader["deptId"]);
                        empList.Add(emp);
                    }
                    return empList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            //set empName = @name, empAddress = @address, emailAddress = @email, empSalary = @salary, deptId = @dept where empId = @id
            public void UpdateEmployee(int id, Employee emp)
            {
                var connection = new SqlConnection(strConnection);
                var command = new SqlCommand(STRUPDATE, connection);
                command.Parameters.AddWithValue("@name", emp.EmpName);
                command.Parameters.AddWithValue("@address", emp.EmpAddres);
                command.Parameters.AddWithValue("@email", emp.EmailAddress);
                command.Parameters.AddWithValue("@salary", emp.EmpSalary);
                command.Parameters.AddWithValue("@dept", emp.DeptId);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected != 1)
                    {
                        throw new EmployeeDbException("Updation has failed as no rows were modified");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
    namespace DataUI
    {
        class DataAccessUI
        {
            static string menufile = ConfigurationManager.AppSettings["menuFile"];
            static void Main(string[] args)
            {
                bool processing = false;
                string menu = File.ReadAllText(menufile);
                do
                {
                    int choice = Utilities.GetNumber(menu);
                    processing = processMenu(choice);
                } while (processing);
            }

            private static bool processMenu(int choice)
            {
                switch (choice)
                {
                    case 1:
                        getAllEmployeesHelper();
                        return true;
                    case 2:
                        addNewEmployeeHelper();
                        return true;
                    case 3:
                        updateEmployeeHelper();
                        return true;
                    case 4:
                        deleteEmployeeHelper();
                        return true;
                    default:
                        return false;
                }
            }

            private static void deleteEmployeeHelper()
            {
                throw new NotImplementedException();
            }

            private static void updateEmployeeHelper()
            {
                int id = Utilities.GetNumber("Enter the Id of the Employee to update");
                Employee emp = createEmployee();
                IDataAccess dataAccess = new ConnectedDataAccess();
                try
                {
                    dataAccess.UpdateEmployee(id, emp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            private static void addNewEmployeeHelper()
            {   
                //call to the lib and pass the employee object to the API
                try
                {
                    var emp = createEmployee();
                    IDataAccess lib = new ConnectedDataAccess();
                    lib.AddNewEmployee(emp);
                }
                catch(Exception ex)//handle any exceptions. 
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            private static Employee createEmployee()
            {
            RETRY:
                try
                {
                    //Take inputs from the user for all the values to store to the database
                    string name = Utilities.GetString("Enter the Name");
                    string address = Utilities.GetString("Enter the Address");
                    string email = Utilities.GetString("Enter the Email Address");
                    int salary = Utilities.GetNumber("Enter the salary");
                    int deptId = Utilities.GetNumber("Enter the DeptId");
                    //create the employee object and set those values
                    var emp = new Employee
                    {
                        EmailAddress = email,
                        EmpName = name,
                        EmpSalary = salary,
                        DeptId = deptId,
                        EmpAddres = address
                    };
                    return emp;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto RETRY;
                }
            }
            private static void getAllEmployeesHelper()
            {
                try
                {
                    IDataAccess lib = new ConnectedDataAccess();
                    var empList = lib.GetAllEmployees();
                    foreach (var emp in empList)
                    {
                        Console.WriteLine(emp.EmpName);
                        //TODO: Show other details also.....
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                } 
            }
        }
    }
}