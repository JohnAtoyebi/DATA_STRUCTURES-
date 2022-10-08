using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public abstract class LinkedList<T>
    {
        protected Node<T> Head = null;
        protected Node<T> Tail = null;
        private int counter = 0;
        private int _size = 0;
        protected int ListSize
        {
            get
            {
                if (Head == null)
                    return 0;

                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                    _size++;
                }
                return _size;
            }
        }

        protected bool Empty
        {
            get
            {
                if (Head == null)
                {
                    return true;
                }
                return false;
            }
        }

        protected void AddEnd(T data)
        {
            Node<T> newItem = new Node<T>(); 
            newItem.Data = data;

            if (Head == null)
            {
                Head = newItem;

                Tail = Head;  
            }
            else
            {
                Tail.Next = newItem;
                Tail = newItem; 
            }
        }

        public void AddBegining(T data)
        {
            Node<T> newItem = new Node<T>(); 
            newItem.Data = data;

            newItem.Next = Head;
            Head = newItem;
            Tail = Head;
        }

        public bool CheckFor(T data)
        {
            if (Head == null)
                throw new NullReferenceException("This data structure is empty");

            if (data.Equals(Head.Data))
                return true;

            while (Head.Next != null)
            {
                Head = Head.Next;
                counter += 1;
                if (data.Equals(Head.Data))
                    return true;

            }

            return false;

        }

        public int IndexOfData(T data)
        {
            if (!CheckFor(data))
                return -1;

            return counter;
        }

        public virtual void PrintList()
        {
            var current = Head;
            if (current == null)
                throw new NullReferenceException("This data structure is empty");

            {
                while (current.Next != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }

                Console.WriteLine(current.Data);
            }

        }

        protected void Delete(T data)
        {
            if (Head == null)
                throw new NullReferenceException("This data structure is empty");

            var current = Head;
            Node<T> prev = null;

            if (data.Equals(Head.Data))
            {
                while (current.Next != null)
                {
                    Head = current.Next;
                    return;
                }
            }

            while (current.Next != null && !data.Equals(current.Data))
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = current.Next;
        }

        protected T DeleteLast()
        {
            if (Head == null)
                throw new NullReferenceException("This data structure is empty");

            var current = Head;
            T temp = Head.Data;

            Head = current.Next;
            Tail = current.Next;
            return temp;

        }

    }
}
