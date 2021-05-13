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
        public SampleController(Person person)
        {
            _person = person;
        }

        public IActionResult Get()
        {
            return Ok();
        }
    }
}
