using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationService.Model.ViewModel;
using ApplicationService.Repository.Abstractions;
using AutoMapper;
using BusinessLogic.Repository.Abstractions;
using Core.Models;

namespace ApplicationService.Repository
{
    public class TestAppService : ITestAppService
    {
        private readonly ITestService _testService;
        private readonly IMapper _mapper;
        public TestAppService(ITestService testService, IMapper mapper)
        {
            _testService = testService;
            _mapper = mapper;
        }

        public IEnumerable<TestViewModel> GetAllTests()
        {
            var result = _testService.Get();
            return result.Select(_mapper.Map<Test, TestViewModel>);
        }

        public TestViewModel GetHighestScore()
        {
            var result = _testService.GetTestWithTheHighestScore();
            return _mapper.Map<Test, TestViewModel>(result);
        }

        public TestViewModel GetLowestScore()
        {
            var result = _testService.GetTestWithTheLowestScore();
            return _mapper.Map<Test, TestViewModel>(result);
        }

        public TestViewModel GetTestById(int id)
        {
            var result = _testService.GetById(id);
            return _mapper.Map<Test, TestViewModel>(result);
        }
    }
}
