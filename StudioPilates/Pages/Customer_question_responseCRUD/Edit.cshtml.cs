using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_question_responseCRUD
{
    public class EditModel : PageModel
    {
        private readonly StudioPilates.Data.ApplicationDbContext _context;

        public EditModel(StudioPilates.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer_question_response Customer_question_response { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer_question_response = await _context.Customer_Question_Responses.FirstOrDefaultAsync(m => m.Id_customer_question_response == id);

            if (Customer_question_response == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Customer_question_response).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Customer_question_responseExists(Customer_question_response.Id_customer_question_response))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Customer_question_responseExists(int id)
        {
            return _context.Customer_Question_Responses.Any(e => e.Id_customer_question_response == id);
        }
    }
}
