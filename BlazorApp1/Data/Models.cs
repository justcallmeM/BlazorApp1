using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IAnimal
    {
        bool CanBark();
        string Name { get; set; }
        string Speed { get; set; }
    }
    public class Bird : IAnimal
    {
        public string Name { get; set; }
        public string Speed { get; set; }

        public bool CanBark()
        {
            return false;
        }
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Speed { get; set; }

        public bool CanBark()
        {
            return false;
        }

    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Speed { get; set; }

        public bool CanBark()
        {
            return false;
        }
    }

    public class Horse : IAnimal
    {
        public string Name { get; set; }
        public string Speed { get; set; }

        public bool CanBark()
        {
            return false;
        }
    }

    public class ModelAnimals
    {
        public List<IAnimal> Animal { get; set; }
        public ModelAnimals()
        {
            this.Animal = new List<IAnimal>();
        }
    }
}
