using ChurchDirectory.DbContext;
using ChurchDirectory.DbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDirectory.Services
{
    public class MinistryService
    {
        private DirectoryDbContext _dbContext;

        public MinistryService(DirectoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Child> GetChildren ()
        {
            return _dbContext.Children.ToList();
        }
    }
}
