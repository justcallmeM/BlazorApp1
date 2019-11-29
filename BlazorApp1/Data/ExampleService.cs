using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ExampleService
    {
        public async Task<int> Multiplication(int a, int b, int c)
        {
            return Task.FromResult(a + b + c).Result;
        }
    }
}
