using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLogic.Repository.Abstractions;
using Core.Models;
using Infrastructure.Repository.Abstractions;

namespace BusinessLogic.Repository
{
    public class TestService : GenericService<Test>, ITestService
    {
        public TestService(ITestRepository testRepository) : base (testRepository)
        {
        }

        public Test GetTestWithTheHighestScore()
        {
            var result = _entityRepository.Get().OrderBy(x => x.Score).FirstOrDefault();
            return result;
        }

        public Test GetTestWithTheLowestScore()
        {
            var result = _entityRepository.Get().OrderByDescending(x => x.Score).FirstOrDefault();
            return result;
        }
    }
}
