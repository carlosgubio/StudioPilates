using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Plan
{
    public class ListModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        public ListModel(StudioPilatesContext context)
        {
            _context = context;
        }

        public IList<Models.Plan> Plan { get; set; }

        public async Task OnGetAsync()
        {
            Plan = await _context.Plans.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plan = await _context.Plans.FindAsync(id);

            if (plan != null)
            {
                _context.Plans.Remove(plan);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./List");
        }
    }
}
