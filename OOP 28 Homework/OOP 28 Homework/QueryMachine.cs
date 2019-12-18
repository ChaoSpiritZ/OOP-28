using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace OOP_28_Homework
{
    public class QueryMachine
    {
        private const string PATH = @"C:\Users\user\Desktop\SQLite\SQLite DBs\1.db";
        private const string VERSION = "3";

        public static void PeekDBEmployees()
        {
            using (SQLiteConnection con = new SQLiteConnection($"Data Source = {PATH}; Version = {VERSION}"))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Employees", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["ID"]} {reader["Name"]} {reader["Age"]} {reader["Address"]} {reader["Salary"]} ");
                        }
                    }
                }
            }
        }

        public static List<Employee> ReadEmployees()
        {
            List<Employee> resultingEmployees = new List<Employee>();
            using (SQLiteConnection con = new SQLiteConnection($"Data Source = {PATH}; Version = {VERSION}"))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Employees", con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee e = new Employee()
                            {
                                ID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Age = reader.GetInt32(2),
                                Address = reader.GetString(3),
                                Salary = reader.GetFloat(4)
                            };
                            resultingEmployees.Add(e);
                        }
                    }
                }
            }
            return resultingEmployees;
        }
    }
}
