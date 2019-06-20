using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Generic_Swap_Method_Integer
{
    public class Box<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            boxCollection = new List<T>();
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
