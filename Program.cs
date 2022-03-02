// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld { 


    public class Program {
        public static void Main(string[] args)
        {
            Console.Write("Name:");
            string input = Console.ReadLine();
            Console.WriteLine($"Hello, {input}!");
        }
    }
}