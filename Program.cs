using HangMan.Helpers;
using System;
using System.Collections.Generic;

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

            var set = CheckWhereCharacterExists('n', "banana");
            Console.WriteLine();


        }
        //we need a method that checks if the letter we chose exists and where
        //we need a method that replaces the _ with the character we found in each location given
        public static HashSet<int> CheckWhereCharacterExists(char character, string word)
        {
            var positions = new HashSet<int>();

            if (word.Contains(character))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == character)
                    {
                        positions.Add(i);
                    }
                }
            }

            return positions;
        }

        public static string ReplaceCharacters(char character, HashSet<int> positions)
        {

        }
    }
}
