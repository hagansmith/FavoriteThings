using System;

namespace FavoriteThings
{
    public class Bees
    {
        protected string _beeName;
        protected int _beeAge;

        public string BeeName
        {
            get
            {
                return _beeName;
            }
            set
            {
                _beeName = value;
            }
        }

        public string BeeAge { get; set; }

        //public int CalculateAge(int age)
        //{
        //    int beesAge = _beeAge * 7;
        //    return beesAge;
        //}
        
        public Bees (string name, int age)
        {
            //int beesAge = CalculateAge(age);
            Console.WriteLine($"My Bee's name is {name}, and he is {age} days old");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Bees("Rocky", 2);

            Console.ReadKey();
        }
    }


}
