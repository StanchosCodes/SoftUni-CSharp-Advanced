using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mealsArr = Console.ReadLine().Split();
            int[] calloriesArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<string> meals = new Queue<string>(mealsArr);
            Stack<int> callories = new Stack<int>(calloriesArr);

            int mealsCount = meals.Count;
            int eatenMealsCount = 0;

            const int SaladCal = 350;
            const int SoupCal = 490;
            const int PastaCal = 680;
            const int SteakCal = 790;

            while (callories.Count > 0 && meals.Count > 0)
            {
                int currCall = callories.Peek();
                for (int i = 0; i < meals.Count; i++)
                {
                    string currMeal = meals.Peek();
                    int currMealCall = 0;

                    if (currMeal == "salad")
                    {
                        currMealCall = SaladCal;
                    }
                    else if (currMeal == "soup")
                    {
                        currMealCall = SoupCal;
                    }
                    else if (currMeal == "pasta")
                    {
                        currMealCall = PastaCal;
                    }
                    else if (currMeal == "steak")
                    {
                        currMealCall = SteakCal;
                    }

                    if (currCall - currMealCall <= 0) // 310 - 310 = 0
                    {
                        currMealCall -= currCall; // 0
                        callories.Pop();
                        meals.Dequeue();
                        eatenMealsCount++;

                        if (callories.Count > 0)
                        {
                            currCall = callories.Peek() - currMealCall; // 1800 - 0
                            callories.Pop(); 
                            callories.Push(currCall); // 1800
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (currCall - currMealCall > 0)
                    {
                        currCall -= currMealCall;
                        meals.Dequeue();
                        callories.Pop();
                        callories.Push(currCall);
                        eatenMealsCount++;
                        i--;
                    }
                }
            }

            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {mealsCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", callories)} calories.");
            }
            else if (callories.Count == 0)
            {
                Console.WriteLine($"John ate enough, he had {eatenMealsCount} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }
        }
    }
}
