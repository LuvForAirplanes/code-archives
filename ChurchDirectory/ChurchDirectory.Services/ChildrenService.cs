using ChurchDirectory.DbContext;
using ChurchDirectory.DbContext.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchDirectory.Services
{
    public class ChildrenService
    {
        private DirectoryDbContext _dbContext;

        public ChildrenService(DirectoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Child>> GetChildrenById(string id)
        {
            return _dbContext.Children.Where(f => f.ParentId == id).ToListAsync();
        }
    }
}
