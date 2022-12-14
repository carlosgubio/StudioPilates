using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_question_responseCRUD
{
    [Authorize(Policy = "isAdmin")]

    public class DetailsModel : PageModel
    {
        private readonly StudioPilates.Data.StudioPilatesContext _context;

        public DetailsModel(StudioPilates.Data.StudioPilatesContext context)
        {
            _context = context;
        }

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
    }
}
