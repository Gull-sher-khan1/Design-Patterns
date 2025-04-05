using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Government
    {
        private static Government? _instance;

        private string _name;
        private Government(string name) 
        { 
            _name = name;
        }

        public static Government GetInstance(string name)
        {
            if (_instance == null)
            {
                _instance = new Government(name);
            }
            return _instance;
        }

        public string getName()
        {
            return _name;
        }
    }
}
