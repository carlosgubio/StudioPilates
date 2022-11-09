using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_question_responseCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly StudioPilates.Data.ApplicationDbContext _context;

        public DeleteModel(StudioPilates.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer_question_response = await _context.Customer_Question_Responses.FindAsync(id);

            if (Customer_question_response != null)
            {
                _context.Customer_Question_Responses.Remove(Customer_question_response);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
