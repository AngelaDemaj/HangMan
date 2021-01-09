using HangMan.Helpers;
using System;

namespace HangMan
{
    class Program
    {
        static string WordToUnderscores(string word)
        {
            var text = "";

            foreach (var character in word)
            {
                text += "_ ";
            }

            return text;
        }
        //train --> _ _ _ _ _
        //1) we need words replaced by _ _ _ _ _ _ _
        //2) we choose a character each turn
        //--> if the char exists it replaces the underscore _
        //--> if the char does not exist we lose a life
        static void Main(string[] args)
        {
            var random = new Random();
            var word = Reader.Words[random.Next(0, Reader.Words.Length)];
            Console.WriteLine(word);
            Console.WriteLine(WordToUnderscores(word));


        }
    }
}
