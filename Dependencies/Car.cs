using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DependencyInjection.Study.Dependencies
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine("Car created");
        }
    }
}
