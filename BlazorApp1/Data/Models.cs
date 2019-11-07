using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Bird
    {
        public string Name { get; set; }
        public string Speed { get; set; }
    }

    public class Dog
    {
        public string Name { get; set; }
        public string Speed { get; set; }

    }

    public class Cat
    {
        public string Name { get; set; }
        public string Speed { get; set; }

    }

    public class Models
    {
        public List<object> AnimalList { get; set; }
    }
}
