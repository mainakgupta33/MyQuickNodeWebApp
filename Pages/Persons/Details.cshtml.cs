using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azure_web_app_sample.Data;

namespace azure_web_app_sample.Pages.Persons
{
    public class DetailsModel : PageModel
    {
        private readonly azure_web_app_sample.Data.AppDbContext _context;

        public DetailsModel(azure_web_app_sample.Data.AppDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Persons.FirstOrDefaultAsync(m => m.Id == id);

            if (person is not null)
            {
                Person = person;

                return Page();
            }

            return NotFound();
        }
    }
}