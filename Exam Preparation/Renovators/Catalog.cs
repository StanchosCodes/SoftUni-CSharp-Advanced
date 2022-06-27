using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public List<Renovator> Renovators { get; set; }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }
        public int Count
        {
            get
            {
                return this.Renovators.Count;
            }
        }

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.Renovators = new List<Renovator>();
        }

        public string AddRenovator(Renovator renovator)
        {
            if (this.Renovators.Count < this.NeededRenovators)
            {
                if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
                {
                    return "Invalid renovator's information.";
                }
                if (renovator.Rate > 350)
                {
                    return "Invalid renovator's rate.";
                }

                this.Renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
            else
            {
                return "Renovators are no more needed.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            foreach (Renovator renovator in this.Renovators)
            {
                if (renovator.Name == name)
                {
                    this.Renovators.Remove(renovator);
                    return true;
                }
            }

            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
           return this.Renovators.RemoveAll(r => r.Type == type);
        }

        public Renovator HireRenovator(string name)
        {
            foreach (Renovator renovator in this.Renovators)
            {
                if (renovator.Name == name)
                {
                    renovator.Hired = true;
                    return renovator;
                }
            }

            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovatorsList = new List<Renovator>();

            foreach (Renovator renovator in this.Renovators)
            {
                if (renovator.Days >= days)
                {
                    renovatorsList.Add(renovator);
                }
            }

            return renovatorsList;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");

            foreach (Renovator renovator in this.Renovators.Where(r => r.Hired == false))
            {
                sb.AppendLine(renovator.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
