using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private string name;
        private int capacity;
        private double landingStrip;
        private List<Drone> drones;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public List<Drone> Drones { get; set; }
        public int Count
        {
            get
            {
                return Drones.Count;
            }
        }

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (Count == Capacity)
            {
                return "Airfield is full.";
            }

            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            return Drones.Remove(Drones.Find(d => d.Name == name));
        }

        public int RemoveDroneByBrand(string brand)
        {
            int removedCount = Drones.RemoveAll(drone => drone.Brand == brand);
            return removedCount;
        }

        public Drone FlyDrone(string name)
        {
            foreach (Drone drone in Drones)
            {
                if (drone.Name == name)
                {
                    drone.Available = false;
                    return drone;
                }
            }

            return null;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> flownDrones = new List<Drone>();

            foreach (Drone drone in Drones)
            {
                if (drone.Range >= range)
                {
                    drone.Available = false;
                    flownDrones.Add(drone);
                }
            }

            return flownDrones;
        }

        public string Report()
        {
            var filtered = Drones.Where(d => d.Available == true);
            return $"Drones available at {Name}:" + Environment.NewLine +
                   string.Join(Environment.NewLine, filtered);
        }
    }
}