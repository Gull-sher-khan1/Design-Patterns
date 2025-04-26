using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IStrategy
    {
        public int Execute(int a, int b);
    }
    public class Context
    {
        public IStrategy strategy { get; set; }

        public Context(IStrategy strategy) 
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int a, int b) 
        {
            return strategy.Execute(a, b);
        }
    }

    public class AdditionStrategy: IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }

    public class SubtractionStrategy: IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
