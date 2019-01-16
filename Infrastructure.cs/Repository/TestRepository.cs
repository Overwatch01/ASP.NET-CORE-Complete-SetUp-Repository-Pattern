using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.DataAccess;
using Infrastructure.Repository.Abstractions;

namespace Infrastructure.Repository
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
