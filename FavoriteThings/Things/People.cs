using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Things
{
    class People
    {
        protected string _nameOfPerson;
        protected int _personAge;

        public string NameOfPerson
        {
            get
            {
                return _nameOfPerson;
            }
            set
            {
                _nameOfPerson = value;
            }
        }

        public int PersonAge
        {
            get
            {
                return _personAge;
            }
            set
            {
                _personAge = value;
            }
        }

        public People (string name, int age)
        {
            Console.WriteLine($"{name}, {age}");
        }

    }
}
