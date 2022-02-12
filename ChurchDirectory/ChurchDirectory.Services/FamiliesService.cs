using ChurchDirectory.DbContext.Models;
using System;
using ChurchDirectory.DbContext;
using ChurchDirectory.Services.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchDirectory.Services
{
    public class FamiliesService
    {
        private DirectoryDbContext _dbContext;
        private ChildrenService _childrenService;

        public FamiliesService(DirectoryDbContext dbContext, ChildrenService childrenService)
        {
            _dbContext = dbContext;
            _childrenService = childrenService;
        }

        public async Task<List<DTOs.Family>> GetFamiliesAsync()
        {
            var families = _dbContext.Families.Take(50);
            var list = new List<DTOs.Family>();
            foreach (var family in families)
            {
                var children = await _childrenService.GetChildrenById(family.ParentId);
                list.Add(new DTOs.Family() { BirthDate = family.BirthDate, City = family.City, Comment1 = family.Comment1, Comment2 = family.Comment2, DeathDate = family.DeathDate, FirstName = family.FirstName, Id = family.Id, LastName = family.LastName, Line1 = family.Line1, MarriedDate = family.MarriedDate, Member = family.Member, ParentId = family.ParentId, Phone1 = family.Phone1, Phone2 = family.Phone2, RecordNumber = family.RecordNumber, Spouse = family.Spouse, SpouseBirthDate = family.SpouseBirthDate, SpouseDeathDate = family.SpouseDeathDate, SpouseId = family.SpouseId, State = family.State, Zip = family.Zip, Children = children });
            }
            return list;
        }

        public async Task<List<DTOs.Family>> GetFamiliesAsync(int index, int items)
        {
            var families = _dbContext.Families.Skip(index).Take(items);
            var list = new List<DTOs.Family>();
            foreach (var family in families)
            {
                var children = await _childrenService.GetChildrenById(family.ParentId);
                list.Add(new DTOs.Family() { BirthDate = family.BirthDate, City = family.City, Comment1 = family.Comment1, Comment2 = family.Comment2, DeathDate = family.DeathDate, FirstName = family.FirstName, Id = family.Id, LastName = family.LastName, Line1 = family.Line1, MarriedDate = family.MarriedDate, Member = family.Member, ParentId = family.ParentId, Phone1 = family.Phone1, Phone2 = family.Phone2, RecordNumber = family.RecordNumber, Spouse = family.Spouse, SpouseBirthDate = family.SpouseBirthDate, SpouseDeathDate = family.SpouseDeathDate, SpouseId = family.SpouseId, State = family.State, Zip = family.Zip, Children = children });
            }
            return list;
        }

        public async Task<DTOs.Family> GetFamilyByIdAsync(string id)
        {
            var family = _dbContext.Families.Where(f => f.Id == id).FirstOrDefault();
            var children = await _childrenService.GetChildrenById(family.Id);
            var newFamily = new DTOs.Family() { BirthDate = family.BirthDate, City = family.City, Comment1 = family.Comment1, Comment2 = family.Comment2, DeathDate = family.DeathDate, FirstName = family.FirstName, Id = family.Id, LastName = family.LastName, Line1 = family.Line1, MarriedDate = family.MarriedDate, Member = family.Member, ParentId = family.ParentId, Phone1 = family.Phone1, Phone2 = family.Phone2, RecordNumber = family.RecordNumber, Spouse = family.Spouse, SpouseBirthDate = family.SpouseBirthDate, SpouseDeathDate = family.SpouseDeathDate, SpouseId = family.SpouseId, State = family.State, Zip = family.Zip, Children = children };
            return newFamily;
        }

        public async Task<(List<DTOs.Family> Items, int PageCount)> GetPagedAsync(int page, int pageSize)
        {
            var items = await GetFamiliesAsync();
            var pageCount = items.GetPageCount(pageSize);
            return (items.Page(page, pageSize), pageCount);
        }
    }
}
