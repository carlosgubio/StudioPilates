using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_paymentCRUD
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Customer_payment Customer_payment { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var customer_payment = new Customer_payment();
            if (await TryUpdateModelAsync<Customer_payment>(customer_payment, "Customer_payment", obj => obj.Id_customer_plan, obj => obj.Paid_value,
                obj => obj.Paid_at, obj => obj.Payment_method, obj => obj.Text))
            {
                _context.Customer_Payments.Add(customer_payment);
                await _context.SaveChangesAsync();
                return RedirectToPage("./List");
            }
            return Page();
        }
    }
}
