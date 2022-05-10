using System;
using System.Linq;

namespace lessons22
{
    internal class Program
    {

        static int[] GetArray()
        {
            int[] myArray = { 1, 2, 3 };

            return myArray;
        }

        static void Main(string[] args)
        {
            int[] myArray = GetArray();



            Console.WriteLine("Колличество эллементов в массиве: " + (myArray?.Sum() ?? 0));
        }
    }
}
