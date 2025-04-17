using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class Iterator: IEnumerator 
    {
        object IEnumerator.Current => Current();

        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }

    public abstract class IteratorAggregate: IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }

    public class StringCollection: IteratorAggregate
    {
        List<string> collection = new List<string> ();

        public void AddItem(string s)
        {
            collection.Add (s);
        }

        public List<string> GetItems()
        {
            return collection;
        }

        public override IEnumerator GetEnumerator()
        {
            return new CollectionIterator(this);
        }
    }

    public class CollectionIterator : Iterator 
    {
        private StringCollection _stringCollection;

        private int _index;

        public CollectionIterator(StringCollection stringCollection)
        {
            _stringCollection = stringCollection;
            _index = 0;
        }

        public override int Key()
        {
            return _index;
        }

        public override object Current()
        {
            return _stringCollection.GetItems()[_index];
        }

        public override bool MoveNext()
        {
            if (_index >= _stringCollection.GetItems().Count() - 1)
            {
                return false;
            }
            else
            {
                _index++;
                return true;
            }
        }


        public override void Reset()
        {
            _index = 0;
        }
    }
}
