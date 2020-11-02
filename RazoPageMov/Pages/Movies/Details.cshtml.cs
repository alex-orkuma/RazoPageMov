﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazoPageMov.Data;
using RazoPageMov.Models;

namespace RazoPageMov.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazoPageMov.Data.RazoPageMovContext _context;

        public DetailsModel(RazoPageMov.Data.RazoPageMovContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
