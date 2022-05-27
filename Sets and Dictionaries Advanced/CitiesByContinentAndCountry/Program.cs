using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continentsCountrysCities = new Dictionary<string, Dictionary<string, List<string>>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                string currContinent = data[0];
                string currCountry = data[1];
                string currCity = data[2];

                if (!continentsCountrysCities.ContainsKey(currContinent))
                {
                    continentsCountrysCities.Add(currContinent, new Dictionary<string, List<string>>());
                }
                if (!continentsCountrysCities[currContinent].ContainsKey(currCountry))
                {
                    continentsCountrysCities[currContinent].Add(currCountry, new List<string>());
                }
                continentsCountrysCities[currContinent][currCountry].Add(currCity);
            }

            foreach (var continent in continentsCountrysCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($"{country.Key} -> {string.Join(", ", country.Value)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
