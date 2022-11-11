using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    public class EditModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        public EditModel(StudioPilatesContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.Id_customer == id);

            if (Customer == null)
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

            _context.Attach(Customer).State = EntityState.Modified;
            _context.Attach(Customer.Address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(Customer.Id_customer))
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

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id_customer == id);
        }
    }
}
