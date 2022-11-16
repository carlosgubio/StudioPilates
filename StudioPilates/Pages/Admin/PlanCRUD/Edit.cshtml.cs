using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.PlanCRUD
{
    [Authorize(Policy = "isAdmin")]
    public class EditModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        public EditModel(StudioPilatesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Plan Plan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plan = await _context.Plans.FirstOrDefaultAsync(m => m.Id_plan == id);

            if (Plan == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Plan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(Plan.Id_plan))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./List");
        }

        private bool PlanExists(int id)
        {
            return _context.Plans.Any(e => e.Id_plan == id);
        }
    }
}
