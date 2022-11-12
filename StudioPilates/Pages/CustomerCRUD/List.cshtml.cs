using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Linq;
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

        public async Task OnGetAsync([FromQuery(Name = "q")] string searchTerm, [FromQuery(Name = "o")] int? order = 1)
        {
            var query = _context.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(c => c.Name.ToLower().Contains(searchTerm.ToLower()));
            }
            if (order.HasValue)
            {
                switch (order.Value)
                {
                    case 1:
                        query = query.OrderBy(c => c.Name.ToLower());
                        break;
                    case 2:
                        query = query.OrderBy(c => c.Birth_date);
                        break;
                }
            }
            Customer = await query.ToListAsync();
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
