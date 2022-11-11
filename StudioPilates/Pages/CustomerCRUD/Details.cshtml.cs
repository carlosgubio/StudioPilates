using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        [BindProperty]
        public Customer Customer { get; set; }

        public string PhotoPath { get; set; }

        public DetailsModel(StudioPilatesContext context, IWebHostEnvironment webHostEnvironment)
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
    }
}
