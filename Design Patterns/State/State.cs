using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class State
    {
        protected Context c;

        public void SetContext(Context c)
        {
            this.c = c;
        }

        public abstract void Handle1();
        public abstract void Handle2();
    }

    public class State1: State
    {
        public override void Handle1()
        {
            Console.WriteLine("Currernt State 1");
            this.c.TransitionTo(new State2());
        }

        public override void Handle2()
        {
            Console.WriteLine("State2 handles request2.");
        }
    }

    public class State2 : State
    {
        public override void Handle2()
        {
            Console.WriteLine("Currernt State 2");
        }

        public override void Handle1()
        {
            Console.WriteLine("State1 handles request1.");
        }
    }
    public class Context
    {
        public State _state { get; set; }

        public Context(State state) 
        {
            TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Transitioning to {state.GetType().Name}");
            this._state = state;
            this._state.SetContext(this);
        }

        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }

    }
}
