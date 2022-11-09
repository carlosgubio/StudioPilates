using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        private readonly ApplicationDbContext _context;   

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
            var customer = new Customer();
            //customer.Address = new Address();

            if (await TryUpdateModelAsync(customer, Customer.GetType(), nameof(Customer)))
            //if (await TryUpdateModelAsync<Customer>(customer, "Customer", obj => obj.Name, obj=> obj.Email, obj => obj.Phone, 
            //    obj => obj.Gender, obj => obj.Occupation, obj => obj.Birth_date))
            {
                _context.Customer.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToPage("./List");
            }
                return Page();
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Customer.Add(Customer);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}
    }
}
