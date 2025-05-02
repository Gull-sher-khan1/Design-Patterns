using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserer
{
    public interface IObserver
    {
        public void Update(Subject subject);
    }

    public class Subject
    {
        public int State { get; set; }

        List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            Console.WriteLine("Subscribing...");
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            Console.WriteLine("Unsubscribing...");
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void changeState()
        {
            Console.WriteLine("Changing state...");
            State = new Random().Next(0,10);
            Notify();
        }
    }

    public class ObserverA: IObserver
    {
        public void Update(Subject subject)
        {
            if(subject.State > 5)
                Console.WriteLine("A did something...");
        }
    }

    public class ObserverB : IObserver
    {
        public void Update(Subject subject)
        {
            if (subject.State <= 5)
                Console.WriteLine("B did something...");
        }
    }
}
