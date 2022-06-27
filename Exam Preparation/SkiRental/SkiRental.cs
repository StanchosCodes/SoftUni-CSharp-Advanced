using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    class SkiRental
    {
        private List<Ski> data;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Ski> Data { get; set; }

        public int Count
        {
            get
            {
                return this.Data.Count;
            }
        }

        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Data = new List<Ski>();
        }

        public void Add(Ski ski)
        {
            if (this.Data.Count < this.Capacity)
            {
                this.Data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if ((this.Data.RemoveAll(ski => ski.Manufacturer == manufacturer && ski.Model == model)) > 0)
            {
                return true;
            }

            return false;
        }

        public Ski GetNewestSki()
        {
            if (this.Data.Count == 0)
            {
                return null;
            }

            Ski newestSki = null;
            int newestYear = 0;

            foreach (Ski ski in this.Data)
            {
                if (ski.Year > newestYear)
                {
                    newestYear = ski.Year;
                    newestSki = ski;
                }
            }

            return newestSki;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            foreach (Ski ski in this.Data)
            {
                if (ski.Manufacturer == manufacturer && ski.Model == model)
                {
                    return ski;
                }
            }

            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The skis stored in {this.Name}:");
            sb.Append(string.Join($"{Environment.NewLine}", this.Data));

            return sb.ToString();
        }
    }
}
