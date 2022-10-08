using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class Queue<T> : LinkedList<T>
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

        public void Enqueue(T data)
        {
            AddEnd(data);
        }

        public T Dequeue()
        {
            return DeleteLast();
        }
    }
}
