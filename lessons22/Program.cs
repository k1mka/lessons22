﻿using System;

namespace lessons22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "test";

            string result = str ?? string.Empty;

            Console.WriteLine("колличество символов в строке: " + result);
        }
    }
}
