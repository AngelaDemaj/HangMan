using HangMan.Helpers;
using System;
using System.Collections.Generic;

namespace HangMan
{
    class Program
    {
        //1) we need words replaced by _ _ _ _ _ _ _
        //2) we choose a character each turn
        //--> if the char exists it replaces the underscore _
        //--> if the char does not exist we lose a life
        static void Main(string[] args)
        {
            PlayHangMan(5);
        }

        public static void PlayHangMan(int lives)
        {
            var random = new Random();
            var word = Reader.Words[random.Next(0, Reader.Words.Length)];
            var hiddenWord = WordHelper.WordToUnderscores(word);
            var playerLives = lives;
            var charactersPlayed = new HashSet<char>();

            while (playerLives > 0 && hiddenWord.Contains('_'))
            {
                Console.WriteLine($"Characters already played: " +
                    $"{string.Join(',', charactersPlayed)}");
                Console.WriteLine($"Lives Remaining: {playerLives}");
                Console.WriteLine($"The word is: {hiddenWord}");
                Console.WriteLine("Enter a character");

                var character = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (charactersPlayed.Contains(character) || !Char.IsLetter(character))
                {
                    Console.Clear();
                    Console.WriteLine("Choose another character");
                }
                else
                {
                    charactersPlayed.Add(character);
                    var set = WordHelper.CheckWhereCharacterExists(character, word);

                    if (set.Count > 0)
                    {
                        hiddenWord = WordHelper.ReplaceCharacters(character, set, hiddenWord);
                        Console.Clear();
                        Console.WriteLine("Character was found");
                    }
                    else
                    {
                        playerLives--;
                        Console.Clear();
                        Console.WriteLine("Character was not found");
                    }
                }
            }
            Console.WriteLine(playerLives > 0 ? "You win!" : "You lost!");

            Console.WriteLine($"The word was: {word}");
        }
    }
}