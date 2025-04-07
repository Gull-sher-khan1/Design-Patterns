using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Component
    {
        public abstract string Operation();
    }

    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "Concrete Class";
        }
    }
    public class Decorator : Component
    {
        protected Component? c;

        public Decorator(Component? c)
        {
            this.c = c;
        }

        public override string Operation()
        {
            if (c != null) 
            {
                return $"Decorator: {c.Operation()}";
            } else
            {
                return "Decorator: Empty";
            }
        }
    }

    public class DecoratorA : Decorator 
    {
        public DecoratorA(Component? c) : base(c)
        {
        }

        public override string Operation() 
        {
            return $"Decorator A: {base.Operation()}";
        }
    }
}
