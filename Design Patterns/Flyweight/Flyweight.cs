using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Flyweight
    {
        private Tree shared_state;

        public Flyweight(Tree tree) 
        {
            shared_state = tree;
        }

    }

    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> _flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Tree[] trees) 
        {

            foreach (var t in trees) 
            {
                if (!FlyweightExists(t))
                    _flyweights.Add(new Tuple <Flyweight, string> (new Flyweight(t), GetKey(t)));
                else
                    Console.WriteLine("Tree exists");
            }
        }

        public string GetKey(Tree tree)
        {
            return $"{tree.Type}_{tree.Color}";
        }

        public bool FlyweightExists(Tree tree)
            => _flyweights.Where(f => f.Item2.Equals(GetKey(tree))).Any();

        public void GetAllFlyweights()
        {
            foreach(var f in _flyweights)
            {
                Console.WriteLine(f.Item2);
            }
        }
    }

    public class Tree
    {
        public string? Color { get; set; }
        public string? Type { get; set; }
    }
}
