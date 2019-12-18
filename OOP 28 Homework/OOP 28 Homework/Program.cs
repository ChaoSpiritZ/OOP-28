using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace OOP_28_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\user\Desktop\SQLite\SQLite DBs\1.db";
            //string version = "3";
            //using(SQLiteConnection con = new SQLiteConnection($"Data Source = {path}; Version = {version}"))
            //{
            //    con.Open();
            //    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Employees", con))
            //    {
            //        using(SQLiteDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                Console.WriteLine($"{reader["ID"]} {reader["Name"]} {reader["Age"]} {reader["Address"]} {reader["Salary"]} ");
            //            }
            //        }
            //    }
            //}
            Console.WriteLine("peeking at the database:");
            QueryMachine.PeekDBEmployees();

            List<Employee> employees = QueryMachine.ReadEmployees();

            employees.ForEach(e => Console.WriteLine(e));
        }
    }
}
