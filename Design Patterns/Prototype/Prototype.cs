using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IPrototype<T>
    {
        public T DeepCopy();
    }

    public class Person:IPrototype<Person>
    {
        public List<string> Names { get; set; }
        public Address Address { get; set; }

        public Person(string firstName, string lastName, Address address) 
        { 
            Names = new List<string>{ firstName, lastName};
            Address = address;
        }

        public Person DeepCopy()
        {
            return new Person(Names[0], Names[1], Address.DeepCopy());
        }

        public override string ToString()
        {
            return $"Name: {Names[0] + " " + Names[1]}, Address: {Address}";
        }
    }

    public class Address: IPrototype<Address> 
    {
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }

        public Address(int houseNumber, string streetName)
        {
            HouseNumber = houseNumber;
            StreetName = streetName;
        }

        public Address DeepCopy() 
        {
            return new Address(HouseNumber, StreetName);
        }

        public override string ToString() 
        {
            return $"{HouseNumber}, {StreetName}";
        }
    }
}
