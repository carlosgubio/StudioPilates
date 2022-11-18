using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_paymentCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly StudioPilates.Data.ApplicationDbContext _context;

        public DetailsModel(StudioPilates.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
