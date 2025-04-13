using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Flyweight
{
    public class Flyweight
    {
        private Tree shared_state;

        public Flyweight(Tree tree) 
        {
            shared_state = tree;
        }

        public void Comparer(Tree tree)
        {
            var shared = JsonConvert.SerializeObject(shared_state);
            var unique = JsonConvert.SerializeObject(tree);
            Console.WriteLine($"Shared: {shared}\n" +
                $"Unique: {unique}");
        }
    }

    public class Tree
    {
        public string Color { get; set; }
        public string Type { get; set; }
    }
}
