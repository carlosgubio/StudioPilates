using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_paymentCRUD
{
    public class EditModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        public EditModel(StudioPilatesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer_payment Customer_payment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer_payment = await _context.Customer_Payments.FirstOrDefaultAsync(m => m.Id_customer_payment == id);

            if (Customer_payment == null)
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

            _context.Attach(Customer_payment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Customer_paymentExists(Customer_payment.Id_customer_payment))
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

        private bool Customer_paymentExists(int id)
        {
            return _context.Customer_Payments.Any(e => e.Id_customer_payment == id);
        }
    }
}
