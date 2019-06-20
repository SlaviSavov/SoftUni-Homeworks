using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Generic_Count_Method_Double
{
    public class Box<T>
        where T : IComparable<T>
    {
        private List<T> boxCollection;

        public int GreaterCount { get; private set; }
        public Box()
        {
            boxCollection = new List<T>();
        }
        public void Compare(T item)
        {
            foreach (var currentItem in boxCollection)
            {
                if (currentItem.CompareTo(item) > 0)
                {
                    GreaterCount++;
                }
            }
        }
        public void Add(T item)
        {
            boxCollection.Add(item);
        }
        public void Swap(int index1, int index2)
        {
            T tempItem = boxCollection[index1];
            boxCollection[index1] = boxCollection[index2];
            boxCollection[index2] = tempItem;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in boxCollection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
