using System;
using System.Collections.Generic;
using System.Text;
using ApplicationService.Model.ViewModel;
using ApplicationService.Repository.Abstractions;
using BusinessLogic.Repository.Abstractions;
using Core.Models;

namespace ApplicationService.Repository
{
    public class TestAppService : ITestAppService
    {
        private readonly ITestService _testService;
        public TestAppService(ITestService testService)
        {
            _testService = testService;
        }

        public IEnumerable<TestViewModel> GetAllTests()
        {
            throw new NotImplementedException();
        }

        public TestViewModel GetHighestScore()
        {
            throw new NotImplementedException();
        }

        public TestViewModel GetLowestScore()
        {
            throw new NotImplementedException();
        }

        public TestViewModel GetTestById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
