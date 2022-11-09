using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly StudioPilates.Data.ApplicationDbContext _context;

        public DetailsModel(StudioPilates.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id_customer == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);

            if (Customer != null)
            {
                _context.Customer.Remove(customer);
                await _context.SaveChangesAsync();
            }
            return Page(); 
        }
    }
}
