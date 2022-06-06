using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public string  Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.NumberOfBadges = numberOfBadges;
            this.Pokemons = pokemons;
        }
    }
}
