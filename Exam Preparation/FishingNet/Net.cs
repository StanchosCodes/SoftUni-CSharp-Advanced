using System.Linq;
using System.Collections.Generic;
using System;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private string material;
        private int capacity;
        private List<Fish> fish;

        public string Material { get; set; }
        public int Capacity { get; set; }
        public List<Fish> Fish { get; private set; }

        public int Count
        {
            get
            {
                return this.Fish.Count;
            }
        }

        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.Fish = new List<Fish>();
        }

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Weight <= 0 || fish.Length <= 0)
            {
                return "Invalid fish.";
            }

            if (this.Fish.Count < this.Capacity)
            {
                this.Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
            else
            {
                return "Fishing net is full.";
            }
        }

        public bool ReleaseFish(double weight)
        {
            bool isFound = false;
            for (int i = 0; i < this.Fish.Count; i++)
            {
                if (this.Fish[i].Weight == weight)
                {
                    this.Fish.RemoveAt(i);
                    i--;
                    isFound = true;
                }
            }

            return isFound;
        }

        public Fish GetFish(string fishType)
        {
            Fish foundFish = this.Fish.First(fish => fish.FishType == fishType);
            return foundFish;
        }

        public Fish GetBiggestFish()
        {
            Fish longestFish = null;
            double longest = 0;

            foreach (Fish fish in Fish)
            {
                if (fish.Length > longest)
                {
                    longest = fish.Length;
                    longestFish = fish;
                }
            }

            return longestFish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Into the {this.Material}:");
            foreach (Fish fish in Fish.OrderByDescending(fish => fish.Length))
            {
                sb.AppendLine(fish.ToString());
            }

           return sb.ToString().TrimEnd();
        }
    }
}
