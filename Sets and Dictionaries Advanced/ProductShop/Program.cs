using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shopData = new Dictionary<string, Dictionary<string, double>>();

            string command;
            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] cmdArgs = command.Split(", ");

                string shop = cmdArgs[0];
                string product = cmdArgs[1];
                double price = double.Parse(cmdArgs[2]);

                if (!shopData.ContainsKey(shop))
                {
                    shopData.Add(shop, new Dictionary<string, double>());
                }
                shopData[shop][product] = price;
            }

            foreach (var shop in shopData.OrderBy(shop => shop.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
