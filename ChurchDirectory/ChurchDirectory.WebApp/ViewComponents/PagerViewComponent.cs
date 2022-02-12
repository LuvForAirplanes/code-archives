using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchDirectory.WebApp.ViewComponents
{
    public class PagerViewComponent : ViewComponent
    {
        public string BaseUrl { get; set; }
        [BindProperty]
        public int PageCount { get; set; }
        [BindProperty]
        public int PageIndex { get; set; }

        public IViewComponentResult Invoke(string baseUrl, int pageCount, int pageIndex)
        {
            BaseUrl = baseUrl;
            PageCount = pageCount;
            PageIndex = pageIndex;
            return View(this);
        }

        public string GetPageUrl(int pageIndex)
        {
            return $"{BaseUrl}&pageIndex={pageIndex}";
        }
    }
}
  