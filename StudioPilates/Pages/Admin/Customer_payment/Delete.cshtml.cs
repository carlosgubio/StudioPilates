using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_paymentCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly StudioPilates.Data.ApplicationDbContext _context;

        public DeleteModel(StudioPilates.Data.ApplicationDbContext context)
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

            Customer_payment = await _context.Customer_Payments.FirstOrDefaultAsync(m => m.Id_customer == id);

            if (Customer_payment == null)
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

            Customer_payment = await _context.Customer_Payments.FindAsync(id);

            if (Customer_payment != null)
            {
                _context.Customer_Payments.Remove(Customer_payment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
