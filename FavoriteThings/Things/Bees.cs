using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Things
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

        public Bees(string name, int age)
        {
            //int beesAge = CalculateAge(age);
            Console.WriteLine($"My Bee's name is {name}, and he is {age} days old");
        }
    }
}
