using System;
using System.Collections.Generic;
using System.Threading;

namespace PigLatin
{
    class Program
    {
        public static void CheckVowels(string word)
        {

        }

        public static void CheckConsonant(string word)
        {

        }
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', };

            Console.WriteLine("Welcome to the Pig Latin translator!");

            //do
            //{

                Console.WriteLine("Please enter a word you want translated");

                string userWord = Console.ReadLine().ToLower();

                foreach (char vowel in vowels)
                {
                    if (userWord[0].Equals(vowel))
                    {
                        Console.WriteLine($"{userWord}way");
                    }
                    else if (!userWord[0].Equals(vowel))
                    {
                        int index = userWord.IndexOfAny(vowels);

                        string frontConsonants = userWord.Substring(0, index);
                        string translation = userWord.Substring(index);

                        Console.WriteLine($"{translation}{frontConsonants}ay");
                        break;

                    }
                }
            //}
            

        }
    }
}
