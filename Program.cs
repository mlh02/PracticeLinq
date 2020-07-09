using System;
using System.Collections.Generic;
using System.Linq;
namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Suburu", "Tesla", "Mercadezs", "Ford", "Chevy" };

            var SCars = from car in cars
                        where car.Contains("s") || car.Contains("S")
                        orderby car.Length
                        select car;
            Console.WriteLine();
            Console.WriteLine("S Lettered Cars:");
            foreach (var car in SCars)
            {
                Console.WriteLine(car);
            }

            string[] games = { "Tekken", "Street Fighter", "King Of Fighter", "BlazBlue", "Mortal Kombat" };

            Console.WriteLine();
            Console.WriteLine("E Lettered Games:");
            //var filteredGames = games.Where(x => x.Contains("e")).OrderBy(x => x);
            var filteredGames = games.OrderBy(aux => aux.Length).ToArray();
            foreach (var game in filteredGames)
            {
                Console.WriteLine(game);
            }

            
        }
    }
}
