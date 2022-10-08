using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class Stack<T> : LinkedList<T>
    {
        public int Size
        {
            get { return ListSize; }
        }

        public bool IsEmpty
        {
            get
            {
                return Empty;
            }
        }

        public void Push(T data)
        {
            AddBegining(data);
        }

        public T Peek()
        {
            if (Tail == null)
                throw new NullReferenceException("Stack is empty");

            return Tail.Data;
        }

        public T Pop()
        {
            return DeleteLast();
        }
    }
}
