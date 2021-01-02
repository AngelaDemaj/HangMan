using HangMan.Helpers;
using System;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var word = Reader.Words[random.Next(0, Reader.Words.Length)];
            Console.WriteLine("Hello World!");
        }
    }
}
