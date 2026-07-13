using System;

namespace crudDemo.Models
{
    public class Employee
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public required string Department { get; set; }
        public Char Gender { get; set; }
    }
}
