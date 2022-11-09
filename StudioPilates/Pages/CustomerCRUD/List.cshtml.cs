using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ListModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);

            if(customer != null)
            {
                _context.Customer.Remove(customer);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./List");
        }
    }
}
