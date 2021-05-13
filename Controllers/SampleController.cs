using AspNetCore.DependencyInjection.Study.Dependencies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DependencyInjection.Study.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly Person _person;
        private readonly Car _car;
        public SampleController(Person person, Car car)
        {
            _person = person;
            _car = car;
        }

        public IActionResult Get()
        {
            return Ok();
        }
    }
}
