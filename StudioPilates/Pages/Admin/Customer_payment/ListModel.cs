using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_payment
{
    public class ListModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        public ListModel(StudioPilatesContext context)
        {
            _context = context;
        }

        public IList<Models.Customer_payment> Customer_payment { get; set; }

        public async Task OnGetAsync()
        {
            Customer_payment = await _context.Customer_Payments.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Customer_Payment = await _context.Customer_Payments.FindAsync(id);

            if (Customer_Payment != null)
            {
                _context.Customer_Payments.Remove(Customer_Payment);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./List");
        }
    }
}
