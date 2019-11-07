using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    abstract class Animal
    {
        public string Name { get; set; }
        public virtual string Color { get; set; }
        public virtual List<string> Limbs { get; set; }
    }

    class Bird : Animal
    {
        
    }

    class Dog : Animal
    {

    }

    class Cat: Animal
    {

    }

    public class Models
    {
        List<object> Animals = new List<object>();
    }
}
