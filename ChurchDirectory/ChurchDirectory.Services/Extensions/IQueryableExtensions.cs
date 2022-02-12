using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChurchDirectory.Services.Extensions
{
    public static class IQueryableExtensions
    {
        public static int GetPageCount<T>(this IQueryable<T> items, int pageSize)
        {
            var totalCount = items.Count();
            var pageCount = (totalCount + pageSize - 1) / pageSize;
            return pageCount;
        }

        public static int GetPageCount<T>(this List<T> items, int pageSize)
        {
            var totalCount = items.Count();
            var pageCount = (totalCount + pageSize - 1) / pageSize;
            return pageCount;
        }

        public static IQueryable<T> Page<T>(this IQueryable<T> context, int page, int pageSize)
        {
            if (pageSize < 1)
                throw new ArgumentException("pageSize may not be less than 1.", nameof(pageSize));

            var query = context.Skip(page * pageSize).Take(pageSize);
            return query;
        }

        public static List<T> Page<T>(this List<T> context, int page, int pageSize)
        {
            if (pageSize < 1)
                throw new ArgumentException("pageSize may not be less than 1.", nameof(pageSize));

            var query = context.Skip(page * pageSize).Take(pageSize);
            return query.ToList();
        }
    }
}
