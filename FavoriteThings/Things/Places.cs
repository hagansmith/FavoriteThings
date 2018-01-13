using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Things
{
    class Places
    {
        protected string _placeName;
        protected int _timesVisited;

        public string PlaceName
        {
            get
            {
                return _placeName;
            }
            set
            {
                _placeName = value;
            }
        }

        public int TimesVisited
        {
            get
            {
                return _timesVisited;
            }
            set
            {
                if (value > 10)
                    Console.WriteLine("That's not possible");
                else
                    _timesVisited = value;
            }
        }

        public Places (string name, int value)
        {
            Console.WriteLine($"I have visited {name}, {visits} times");
        }
          
    }
}
