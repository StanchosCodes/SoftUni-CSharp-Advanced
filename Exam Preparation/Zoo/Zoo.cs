using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;
        private string name;
        private int capacity;

        public List<Animal> Animals { get; private set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Zoo(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Animals = new List<Animal>();
        }

        public string AddAnimal(Animal animal)
        {
            if (this.Animals.Count < this.Capacity)
            {
                if (string.IsNullOrWhiteSpace(animal.Species))
                {
                    return "Invalid animal species.";
                }

                if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                {
                    return "Invalid animal diet.";
                }

                this.Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
            else
            {
                return "The zoo is full.";
            }
        }

        public int RemoveAnimals(string species)
        {
            int removedAnimals = this.Animals.RemoveAll(animal => animal.Species == species);

            return removedAnimals;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalsByDiet = new List<Animal>();

            foreach (Animal animal in this.Animals)
            {
                if (animal.Diet == diet)
                {
                    animalsByDiet.Add(animal);
                }
            }

            return animalsByDiet;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal animalByWeight = this.Animals.First(animal => animal.Weight == weight);

            return animalByWeight;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int counter = 0;

            foreach (Animal animal in this.Animals)
            {
                if (animal.Length >= minimumLength && animal.Length <= maximumLength)
                {
                    counter++;
                }
            }

            return $"There are {counter} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
