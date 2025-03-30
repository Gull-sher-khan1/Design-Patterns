using SingleResponsibilityPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public enum PositionLevel
    {
        Junior,
        Mid,
        Senior
    }
    public class Employee
    {
        public PositionLevel level { get; set; }
        public int salary { get; set; }
    }
    public class PersonBuilder
    {
        private Employee _emp;
        public PersonBuilder Create()
        {
            _emp = new Employee();
            return this;
        }
        public PersonBuilder AssignedAt(PositionLevel lvl)
        {
            _emp.level = lvl;
            return this;
        }
        public PersonBuilder HasSalary(int salary)
        {
            _emp.salary = salary;
            return this;
        }
        public Employee Build()
        {
            return _emp;
        }
    }
}
