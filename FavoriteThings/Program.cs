using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var favoriteBee = new Bees();

            Console.WriteLine(favoriteBee.BeeName);
        }
    }

     public class Bees
    {
        protected string _beeName;
        
        public string BeeName
        {
            get
            {
                return $"My bee's name is {_beeName}";
            }
            set
            {
               var _beeName = "rocky";
            }
        }
    }
}
