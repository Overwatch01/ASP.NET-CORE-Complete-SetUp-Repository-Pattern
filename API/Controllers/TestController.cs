using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationService.Repository.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestAppService _testAppService;

        public TestController(ITestAppService testAppService)
        {
            _testAppService = testAppService;
        }

        [HttpGet("GetAllTests")]
        public IActionResult GetAllTests()
        {
            var result = _testAppService.GetAllTests();
            return Ok(result);
        }

        [HttpGet("GetTestById/{id}")]
        public IActionResult GetAllTests([FromRoute] int id)
        {
            var result = _testAppService.GetTestById(id);
            return Ok(result);
        }
    }
}