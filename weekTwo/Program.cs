using DataStructuresTask.Lib;
using System;

namespace DataStructuresTask
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {   

                SimpleLinkedList<int> list = new SimpleLinkedList<int>();
                list.AddLast(1);
                list.AddLast(2);
                list.AddLast(3);
                list.AddLast(4);

                list.PrintList();

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n");
            }
        }

    }

}
