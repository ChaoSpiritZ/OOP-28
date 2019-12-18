using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_28_Homework
{
    public class Employee //poco
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public float Salary { get; set; }

        public Employee()
        {
        }

        public override string ToString()
        {
            return $"Employee --- ID: {ID}, Name: {Name}, Age: {Age}, Address: {Address}, Salary: {Salary}";
        }
    }
}
