using System;

namespace lessons22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "test 3";

            str ??= "default string";

            Console.WriteLine("колличество символов в строке: " + str);
        }
    }
}
