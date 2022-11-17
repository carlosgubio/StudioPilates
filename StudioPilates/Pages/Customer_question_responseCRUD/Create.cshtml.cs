using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Threading.Tasks;

namespace StudioPilates.Pages.Customer_question_responseCRUD
{
    [Authorize(Policy = "isAdmin")]

    public class CreateModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public Customer Customer { get; set; }
        public string PhotoPath { get; set; }

        [BindProperty]
        public Customer_question_response Customer_question_response { get; set; }

        public CreateModel(StudioPilatesContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            PhotoPath = "~/Photo";
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.Id_customer == id);

            if (Customer == null)
            {
                return NotFound();
            }

            PhotoPath = $"~/Photo/{Customer.Id_customer:D6}.jpeg";

            return Page();
        }
            public async Task<IActionResult> OnPostAsync()
            {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customer_Question_Responses.Add(Customer_question_response);
            await _context.SaveChangesAsync();

            return RedirectToPage("./List");
        }
    }
}
