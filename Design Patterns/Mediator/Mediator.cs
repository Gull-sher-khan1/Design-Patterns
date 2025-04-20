using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediator
    {
        public void Notify(BaseComponent cmp, string ev);
    }

    public class BaseComponent
    {
        protected IMediator mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }

    }

    public class ConcreteComponent1: BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component1 does A.");
            this.mediator.Notify(this, "A");
        }

        public void DoB() 
        {
            Console.WriteLine("Component1 does B.");
            this.mediator.Notify(this, "B");
        }
    }

    public class ConcreteComponent2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component2 does C.");
            this.mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("Component2 does D.");
            this.mediator.Notify(this, "D");
        }
    }

    public class ConcreteMediator : IMediator 
    {
        private ConcreteComponent1 coc1;
        private ConcreteComponent2 coc2;

        public ConcreteMediator(ConcreteComponent1 coc1, ConcreteComponent2 coc2)
        {
            this.coc1 = coc1;
            coc1.SetMediator(this);
            this.coc2 = coc2;
            coc2.SetMediator(this);
        }

        public void Notify(BaseComponent component, string ev)
        {
            if(ev == "A")
            {
                Console.WriteLine("coc1 did A");
                coc2.DoC();
            }
            else if (ev == "D") 
            {
                coc1.DoB();
                coc2.DoC();
            }
        }
    }
}
