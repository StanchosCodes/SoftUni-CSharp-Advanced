using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = command.Split();

                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int pokemonHealth = int.Parse(cmdArgs[3]);

                if (trainers.Any(t => t.Name == trainerName))
                {
                    int index = trainers.FindIndex(t => t.Name == trainerName);
                    trainers[index].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    continue;
                }

                Trainer newTrainer = new Trainer(trainerName, 0, new List<Pokemon> { new Pokemon(pokemonName, pokemonElement, pokemonHealth)});


                trainers.Add(newTrainer);
            }

            string command2;
            while ((command2 = Console.ReadLine()) != "End")
            {
                if (command2 == "Fire")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(pokemon => pokemon.Element == command2))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            for (int i = 0; i < trainer.Pokemons.Count; i++)
                            {
                                trainer.Pokemons[i].Health = trainer.Pokemons[i].Health - 10;

                                if (trainer.Pokemons[i].Health <= 0)
                                {
                                    trainer.Pokemons.RemoveAt(i);
                                    i--;
                                }
                            }
                        }
                    }
                }
                else if (command2 == "Water")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(pokemon => pokemon.Element == command2))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            for (int i = 0; i < trainer.Pokemons.Count; i++)
                            {
                                trainer.Pokemons[i].Health = trainer.Pokemons[i].Health - 10;

                                if (trainer.Pokemons[i].Health <= 0)
                                {
                                    trainer.Pokemons.RemoveAt(i);
                                    i--;
                                }
                            }
                        }
                    }
                }
                else if (command2 == "Electricity")
                {
                    foreach (Trainer trainer in trainers)
                    {
                        if (trainer.Pokemons.Any(pokemon => pokemon.Element == command2))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            for (int i = 0; i < trainer.Pokemons.Count; i++)
                            {
                                trainer.Pokemons[i].Health = trainer.Pokemons[i].Health - 10;

                                if (trainer.Pokemons[i].Health <= 0)
                                {
                                    trainer.Pokemons.RemoveAt(i);
                                    i--;
                                }
                            }
                        }
                    }
                }
            }

            foreach (Trainer trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
