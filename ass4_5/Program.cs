using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass4_5
{
    public class CustomList<T>
    {
        private T[] items;

        public CustomList(int capacity)
        {
            items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                return items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                items[index] = value;
            }
        }

        public int Count
        {
            get { return items.Length; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>(5);

          
            myList[0] = 10;
            myList[1] = 20;
            myList[2] = 30;

           
            Console.WriteLine($"Element at index 0: {myList[0]}");
            Console.WriteLine($"Element at index 1: {myList[1]}");
            Console.WriteLine($"Element at index 2: {myList[2]}");

        }
    }
}
