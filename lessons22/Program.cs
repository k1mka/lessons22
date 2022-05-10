using System;

namespace lessons22
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;

            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();

            myArray ??= new int[0];

            Console.WriteLine("Колличество эллементов в массиве:" + myArray.Length);
        }
    }
}
