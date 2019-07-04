using System;

namespace CustomDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.AddLast("dasdas");
            doublyLinkedList.AddLast("sdadad");
            doublyLinkedList.AddLast("123123");
            doublyLinkedList.AddLast("ad111221dad");

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
