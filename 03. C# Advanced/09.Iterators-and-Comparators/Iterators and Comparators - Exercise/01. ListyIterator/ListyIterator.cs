using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01._ListyIterator
{
    public class ListyIterator<T> :IEnumerable <T>
    {
        private List<T> items;
        private int index;
        public ListyIterator(List<T>items)
        {
            this.items = items;
            this.index = 0;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (index < this.items.Count - 1)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (items.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(items[index]); 
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var currentItem in items)
            {
                yield return currentItem; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
