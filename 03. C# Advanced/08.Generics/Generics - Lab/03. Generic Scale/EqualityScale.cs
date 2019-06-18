using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T> where T:IComparable
    {
        private T Left;
        private T Right;

        public EqualityScale(T left,T right)
        {
            Left = left;
            Right = right;
        }


        public bool AreEqual()
        {
            return Left.CompareTo(Right) == 0;
        }
        public void WhichIsHavier()
        {
            int result = Left.CompareTo(Right);
            if (result==0)
            {
                Console.WriteLine("Right and Left are equal.");
            }
            else if (result>0)
            {
                Console.WriteLine("Left is havier.");
            }
            else if(result<0)
            {
                Console.WriteLine("Right is havier.");
            }
        }
    }
}
        