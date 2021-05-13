using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DependencyInjection.Study.Dependencies
{
    public class Person
    {
        private readonly Car _car;

        public Person(Car car)
        {
            Console.WriteLine("Person created");
            _car = car;
        }
    }
}
