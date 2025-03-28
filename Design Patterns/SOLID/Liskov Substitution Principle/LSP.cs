using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public interface IAnimal
    {
        public void MakeSound();
    }

    public class Cat: IAnimal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Meow");
        } 
    }

    public class Tiger: Cat
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
