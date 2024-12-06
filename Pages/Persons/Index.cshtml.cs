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
    public class IndexModel : PageModel
    {
        private readonly azure_web_app_sample.Data.AppDbContext _context;

        public IndexModel(azure_web_app_sample.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
