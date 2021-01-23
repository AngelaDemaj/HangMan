using System.Collections.Generic;

namespace HangMan.Helpers
{
    static class WordHelper
    {
        public static string WordToUnderscores(string word)
        {
            var text = "";

            foreach (var character in word)
            {
                text += "_ ";
            }

            return text;
        }

        //Method that checks if the letter we chose exists and where
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

        //Characters of original word change location like below
        //0 --> 0
        //1 --> 2
        //2 --> 4
        //3 --> 6
        //4 --> 8
        //5 --> 10

        //we need a method that replaces the _ with the character we found
        public static string ReplaceCharacters(
            char character, HashSet<int> positions, string word)
        {
            char[] characters = word.ToCharArray();

            foreach (var position in positions)
            {
                characters[position * 2] = character;
            }
            return new string(characters);
        }
    }
}
