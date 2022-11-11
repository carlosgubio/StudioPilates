using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    //[Authorize(Policy = "isAdmin")]
    public class ListModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        //public IList<string> EmailsAdmins { get; set; }

        public ListModel(StudioPilatesContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);

            if(customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./List");
        }
    }
}
