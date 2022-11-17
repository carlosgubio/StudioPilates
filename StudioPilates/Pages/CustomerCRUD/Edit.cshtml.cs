using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudioPilates.Data;
using StudioPilates.Models;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    //[Authorize(Policy = "isAdmin")]

    public class EditModel : PageModel
    {
        private readonly StudioPilatesContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        [BindProperty]
        public Customer Customer { get; set; }

        public string PhotoPath { get; set; }

        [BindProperty]
        [Display(Name = "Foto do Cliente")]
        [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        public IFormFile CustomerPhoto { get; set; }
        public EditModel(StudioPilatesContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            PhotoPath = "~/Photo/";
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(c => c.Id_customer == id);

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

            _context.Attach(Customer).State = EntityState.Modified;
            _context.Attach(Customer.Address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                //se há uma imagem de produto submetida
                if (CustomerPhoto != null)
                    await AppUtils.ProcessPhotoFile(Customer.Id_customer, CustomerPhoto, _webHostEnvironment);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(Customer.Id_customer))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToPage("./List");
        }
        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id_customer == id);
        }
    }
}
