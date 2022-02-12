using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChurchDirectory.DbContext.Models;
using ChurchDirectory.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChurchDirectory.WebApp.Pages
{
    public class FamiliesModel : PageModel
    {
        private FamiliesService _familiesService;

        public FamiliesModel(FamiliesService familiesService)
        {
            _familiesService = familiesService;
        }

        public List<Services.DTOs.Family> Families { get; set; }

        public Services.DTOs.Family CurrentFamily { get; set; }

        public async Task OnGetAsync(string id)
        {
            Families = await _familiesService.GetFamiliesAsync();

            if (id != null)
                CurrentFamily = await _familiesService.GetFamilyByIdAsync(id);
        }
    }
}