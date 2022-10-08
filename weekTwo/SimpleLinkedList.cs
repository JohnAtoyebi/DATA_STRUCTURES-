using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class SimpleLinkedList<T> : LinkedList<T>
    {
        public void AddLast(T data)
        {
            AddEnd(data);
        }

        public void AddFirst(T data)
        {
            AddBegining(data);
        }

        public void Remove(T data)
        {
            Delete(data);
        }
    }
}
