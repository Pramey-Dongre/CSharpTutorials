using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    class Person
    {
        public string Name { get; set; }
        public int YearOfBirth { get; init; }

        public Person(string name)
        {
            Name = name;
        }
    }

}
