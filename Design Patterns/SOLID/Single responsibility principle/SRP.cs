using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    // Person has the responsibility related to an object but 
    // it is saved through different class that has the responsibility
    // to save the object.
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() 
        {
            return $"{Name} is {Age} years old.";
        }
    }

    public class Persistance
    {
        public string Filename { get; set; }

        public Persistance(string filename)
        {
            Filename = filename;
        }

        public void Save(Object obj)
        {
            using (StreamWriter w = File.AppendText(Filename))
            {
                w.WriteLine(obj.ToString());
            }
        }
    }
}
