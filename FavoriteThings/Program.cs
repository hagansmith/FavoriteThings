using System;
using System.Collections.Generic;
using FavoriteThings.Things;

namespace FavoriteThings
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //my favorite things

            var allMyBees = new List<Bees>
            {
                new Bees {BeeName = "Rocky", BeeAge = 2, Flight = true },
                new Bees {BeeName = "BamBam", BeeAge = 4, Flight = false},
                new Bees {BeeName = "TomTom", BeeAge = 6, Flight = true}
            };

            var persons = new List<People>
            {
                new People { NameOfPerson = "Micah", PersonAge = 30 },
                new People { NameOfPerson = "Rowan", PersonAge = 0},
                new People { NameOfPerson = "Wesley", PersonAge = 3}
            };

            var allThePlaces = new List<Places>
            {
               new Places { PlaceName = "NYC", TimesVisited = 11 },
               new Places { PlaceName = "LA", TimesVisited = 1}
            };

            var beers = new List<Beer>
            {
                new Beer { Name = "Creature Comforts", Type = "IPA", Can = false},
                new Beer { Name = "Little Harpeth", Type = "Lager", Can = true},
                new Beer { Name = "Mantra", Type = "Ale", Can = false }
            };
           
            foreach (var place in allThePlaces)
            {
                Console.WriteLine($"{place.PlaceName} is not my favorite place but it is popular. I have visited {place.PlaceName} {place.TimesVisited} times.");
            }

            foreach (var beer in beers)
            {
                Console.WriteLine($"{beer.Name} is in a {(beer.Can ? "can" : "bottle")} and is a {beer.Type}");
            }

            foreach (var bee in allMyBees)
            {
                Console.WriteLine($"My favorite bee is {bee.BeeName} he is {bee.BeeAge} days old and {(bee.Flight ? "can" : "can not")} fly.");
            }

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.NameOfPerson} is my favorite person and is {person.PersonAge} old");
            }
                Console.ReadKey();
        }
    }


}
