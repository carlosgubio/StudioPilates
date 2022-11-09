using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_question_responseCRUD
{
    public class CreateModel : PageModel
    {
        private readonly StudioPilates.Data.ApplicationDbContext _context;

        public CreateModel(StudioPilates.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Customer_question_response Customer_question_response { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer_Question_Responses.Add(Customer_question_response);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
