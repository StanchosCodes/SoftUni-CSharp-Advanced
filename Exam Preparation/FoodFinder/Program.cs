using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowelsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] consonantsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            Queue<char> vowels = new Queue<char>(vowelsArr);
            Stack<char> consonants = new Stack<char>(consonantsArr);

            Dictionary<string, List<char>> foods = new Dictionary<string, List<char>>()
            {
                { "pear", new List<char>(){ 'p', 'e', 'a', 'r'} },
                { "flour", new List<char>(){ 'f', 'l', 'o', 'u', 'r'} },
                { "pork", new List<char>(){ 'p', 'o', 'r', 'k'} },
                { "olive", new List<char>(){ 'o', 'l', 'i', 'v', 'e'} }
            };

            int wordsFound = 0;

            while (consonants.Count > 0)
            {
                char currVowel = vowels.Peek();
                char currConsonant = consonants.Peek();

                foreach (var food in foods.Where(f => f.Value.Count != 0))
                {
                    if (food.Value.Contains(currVowel))
                    {
                        food.Value.Remove(currVowel);
                    }
                    if (food.Value.Contains(currConsonant))
                    {
                        food.Value.Remove(currConsonant);
                    }

                    if (food.Value.Count == 0)
                    {
                        wordsFound++;
                    }
                }

                consonants.Pop();
                vowels.Enqueue(vowels.Dequeue());
            }

            Console.WriteLine($"Words found: {wordsFound}");
            foreach (var food in foods.Where(f => f.Value.Count == 0))
            {
                Console.WriteLine(food.Key);
            }
        }
    }
}
