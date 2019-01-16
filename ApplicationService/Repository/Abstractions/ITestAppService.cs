using System;
using System.Collections.Generic;
using System.Text;
using ApplicationService.Model.ViewModel;

namespace ApplicationService.Repository.Abstractions
{
    public interface ITestAppService
    {
        IEnumerable<TestViewModel> GetAllTests();
        TestViewModel GetTestById(int id);
        TestViewModel GetHighestScore();
        TestViewModel GetLowestScore();
    }
}
