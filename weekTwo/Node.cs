using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTask.Lib
{
    public class Node<T>
    {
        public T Data = default(T);
        public Node<T> Next = null;
    }
}
