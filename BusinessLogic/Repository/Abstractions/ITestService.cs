using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;

namespace BusinessLogic.Repository.Abstractions
{
    public interface ITestService : IGenericService<Test>
    {
        Test GetTestWithTheHighestScore();
        Test GetTestWithTheLowestScore();
    }
}
