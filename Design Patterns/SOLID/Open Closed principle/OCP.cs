using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleResponsibilityPrinciple;

// open for extension closed for modification
namespace OpenClosedprinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class AgeSpecification : ISpecification<Person>
    {
        private int Age { get; set; }

        public AgeSpecification(int age)
        {
            Age = age;
        }

        public bool IsSatisfied(Person p)
        {
            return p.Age == Age;
        }
    }

    public class NameSpecification : ISpecification<Person>
    {
        private string Name { get; set; }

        public NameSpecification(string name)
        {
            Name = name;
        }

        public bool IsSatisfied(Person p)
        {
            return p.Name == Name;
        }
    }

    public class PersonFilter : IFilter<Person>
    {
        public IEnumerable<Person> Filter(IEnumerable<Person> people, ISpecification<Person> spec) 
        {
            foreach(Person p in people)
            {
                if (spec.IsSatisfied(p))
                    yield return p;
            }
        }
    }
}
