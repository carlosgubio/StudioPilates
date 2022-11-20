using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_plan
{
    public class CreateModel : PageModel
    {
        private readonly StudioPilates.Data.StudioPilatesContext _context;

        public CreateModel(StudioPilates.Data.StudioPilatesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Customer_plan Customer_plan { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer_plans.Add(Customer_plan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
