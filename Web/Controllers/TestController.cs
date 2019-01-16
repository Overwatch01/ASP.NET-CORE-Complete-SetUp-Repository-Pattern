using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationService.Repository.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestAppService _testAppService;

        public TestController(ITestAppService testAppService)
        {
            _testAppService = testAppService;
        }

        public IActionResult GetAllTests()
        {
            var tests = _testAppService.GetAllTests();
            return View(tests);
        }

        public IActionResult GetTestById(int id)
        {
            var test = _testAppService.GetTestById(id);
            return View(test);
        }
    }
}