using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_planCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly StudioPilates.Data.StudioPilatesContext _context;

        public DeleteModel(StudioPilates.Data.StudioPilatesContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer_plan = await _context.Customer_plans.FindAsync(id);

            if (Customer_plan != null)
            {
                _context.Customer_plans.Remove(Customer_plan);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
