using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private class LinkNode
        {
            public int Value { get; private set; }
            public LinkNode NextNode { get; set; }
            public LinkNode PreviousNode { get; set; }

            public LinkNode(int value)
            {
                Value = value;
            }
        }

        private LinkNode head;
        private LinkNode tail;  
        public int Count { get;private set; }

        public void AddFirst(int value)
        {
            LinkNode newHead = new LinkNode(value);
            if (Count==0)
            {
                head = newHead;
                tail = newHead;
            }
            else
            {
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }
            Count++;
        }
        public void AddLast(int value)
        {
            LinkNode newTail = new LinkNode(value);
            if (Count==0)
            {
                head = newTail;
                tail = newTail;
            }
            else
            {
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }
            Count++;
        }
        public int RemoveFirst()
        {
            CheckIfEmptyThrowExeption();
            int firstElement = head.Value;
            head = head.NextNode;
            if (head==null)
            {
                tail = null;
            }
            else
            {
                head.PreviousNode = null;
            }
            Count--;
            return firstElement;
        }
        public int RemoveLast()
        {
            CheckIfEmptyThrowExeption();
            int lastElement = tail.Value;
            tail = tail.PreviousNode;

            if (tail==null)
            {
                head = null;
            }
            else
            {
                tail.NextNode = null;
            }
            Count--;
            return lastElement;

        }


        public void Print(Action<int> action)
        {
            LinkNode currentNode = head;
            while (currentNode!=null)
            {
                action(currentNode.Value);


                currentNode = currentNode.NextNode;
            }
        }
        public bool Contains(int value)
        {
            LinkNode currentNode = head;
            while (currentNode!=null)
            {
                if (currentNode.Value==value)
                {
                    return true;
                }
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];
            var currentNode = head;
            int counter = 0;
            while (currentNode!=null)
            {
                array[counter++] = currentNode.Value;

                currentNode = currentNode.NextNode;
            }
            return array;
        }
        private void CheckIfEmptyThrowExeption()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }
        }

    }
}
