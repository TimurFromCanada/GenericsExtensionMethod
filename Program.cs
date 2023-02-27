using System;
using GenericsMyList;

namespace GenericsExtensionMethod
{
    public static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> myList)
        {
            var array = new T[myList.Count];

            for (var i = 0; i < myList.Count; i++)
            {
                array[i] = myList.Indexer(i);
            }

            return array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var array = new MyList<double>();
            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                array.AddElement(random.Next(0, 100));
            }

            foreach (var e in array.GetArray())
            {
                Console.WriteLine(e);
            }
        }
    }
}
