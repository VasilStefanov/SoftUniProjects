using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battle2._0
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

            for (int battles = 1; battles <= numberBattles; battles++)
            {
                Console.WriteLine("({0} <-> {1) (0} <-> {1})", numberOfPokemon, numberOfPokemon2);
                for (int i = 1; i <= numberBattles; i++)
                {

                }
            }
        }
    }
}
