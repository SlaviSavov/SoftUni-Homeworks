﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>:IEnumerable<T>
        where T:IComparable<T>
    {
        private class LinkNode
        {
            public T Value { get; private set; }
            public LinkNode NextNode { get; set; }
            public LinkNode PreviousNode { get; set; }

            public LinkNode(T value)
            {
                Value = value;
            }
        }

        private LinkNode head;
        private LinkNode tail;  
        public int Count { get;private set; }

        public void AddFirst(T value)
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
        public void AddLast(T value)
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
        public T RemoveFirst()
        {
            CheckIfEmptyThrowExeption();
            T firstElement = head.Value;
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
        public T RemoveLast()
        {
            CheckIfEmptyThrowExeption();
            T lastElement = tail.Value;
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


        public void Print(Action<T> action)
        {
            LinkNode currentNode = head;
            while (currentNode!=null)
            {
                action(currentNode.Value);


                currentNode = currentNode.NextNode;
            }
        }
        public bool Contains(T value)
        {
            LinkNode currentNode = head;
            while (currentNode!=null)
            {
                if (currentNode.Value.CompareTo(value)==0)
                {
                    return true;
                }
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
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

        public IEnumerator<T> GetEnumerator()
        {
            LinkNode currentNode = head;
            while (currentNode != null)
            {
                yield return currentNode.Value;


                currentNode = currentNode.NextNode;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
