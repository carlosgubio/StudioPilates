using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_planCRUD
{
    public class EditModel : PageModel
    {
        private readonly StudioPilates.Data.StudioPilatesContext _context;

        public EditModel(StudioPilates.Data.StudioPilatesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer_plan Customer_plan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer_plan = await _context.Customer_plans.FirstOrDefaultAsync(m => m.Id_customer_plan == id);

            if (Customer_plan == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Customer_plan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Customer_planExists(Customer_plan.Id_customer_plan))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Customer_planExists(int id)
        {
            return _context.Customer_plans.Any(e => e.Id_customer_plan == id);
        }
    }
}
