using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IAnimal // implementing smaller interfaces as some animals dont swim or fly
    {
        public void Swim();
        public void Walk();
        public void Fly();
    }

    public interface IFish
    {
        public void Swim();
    }

    public interface ILandAnimal
    {
        public void Walk();
    }

    public class Penguin: ILandAnimal, IFish
    {
        public void Walk()
        {
            //walk
        }
        public void Swim()
        {
            // swim
        }
    }

}
