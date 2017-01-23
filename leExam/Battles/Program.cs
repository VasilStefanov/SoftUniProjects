using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayersPokemons = int.Parse(Console.ReadLine());
            int secondPlayerPokemons = int.Parse(Console.ReadLine());
            int numberBattles = int.Parse(Console.ReadLine());
            int numberOfPokemon = 1;
            int numberOfPokemon2 = 1;

            for (int battles = 0; battles < numberBattles; battles++)
            {
                Console.Write("({0} <-> {1}) ", numberOfPokemon, numberOfPokemon2);

                if (numberOfPokemon2 != secondPlayerPokemons)
                {
                    numberOfPokemon2++;
                }
                else if (numberOfPokemon != firstPlayersPokemons)
                {
                    numberOfPokemon++;
                    if (true)
                    {

                    }
                }
                else if (numberOfPokemon2 == secondPlayerPokemons)
                {
                    numberOfPokemon2 = 1;
                    if (numberOfPokemon > firstPlayersPokemons)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
