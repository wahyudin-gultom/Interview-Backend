using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wahyudingultom_test.Interfaces;
using Wahyudingultom_test.Repository;

namespace Wahyudingultom_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuitController : ControllerBase
    {
        private readonly IModuitApi moduitApi;
        public ModuitController(IConfiguration config)
        {
            moduitApi = new ModuitApi();
            moduitApi.configuration = config;
        }

        [HttpGet]
        [Route("Result/One")]
        public IActionResult FirstResult()
        {
            var result = moduitApi.GetApiOne();
            if (result == null) return BadRequest("There is something wrong");
            return Ok(result);
        }

        [HttpGet]
        [Route("Result/Two")]
        public IActionResult SecondResult(string stringContain, string tags, int limit)
        {
            var result = moduitApi.GetApiTwo(stringContain, tags, limit);
            if (result == null) return BadRequest("There is something wrong");
            return Ok(result);
        }

        [HttpGet]
        [Route("Result/Three")]
        public IActionResult ThirdResult()
        {
            var result = moduitApi.GetApiThree();
            if (result == null) return BadRequest("There is something wrong");
            return Ok(result);
        }
    }
}
