using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_question_responseCRUD
{
    public class IndexModel : PageModel
    {
        private readonly StudioPilates.Data.StudioPilatesContext _context;

        public IndexModel(StudioPilates.Data.StudioPilatesContext context)
        {
            _context = context;
        }

        public IList<Customer_question_response> Customer_question_response { get; set; }

        public async Task OnGetAsync()
        {
            Customer_question_response = await _context.Customer_Question_Responses.ToListAsync();
        }
    }
}
