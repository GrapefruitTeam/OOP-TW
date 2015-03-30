using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public Person()
        {
        }
        
        public string Name { get; set; }
    }
}
