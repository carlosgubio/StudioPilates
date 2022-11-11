using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Data;
using StudioPilates.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    //[Authorize(Policy = "isAdmin")]
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        private readonly StudioPilatesContext _context;

        public IActionResult OnGet()
        {
            return Page();
        }

        private readonly IWebHostEnvironment _webHostEnvironment;

        public string PhotoPath { get; set; }

        [BindProperty]
        [Display(Name = "Foto do Cliente")]
        public IFormFile CustomerPhoto { get; set; }
        public CreateModel(StudioPilatesContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            PhotoPath = "~/Photo/sem_imagem.jpg";
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var customer = new Customer();
            customer.Address = new Address();
            //novos clientes sempre iniciam com essa situação
            customer.Status = Customer.CustomerStatus.Ativo;

            if (await TryUpdateModelAsync(customer, Customer.GetType(), nameof(Customer)))
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                await AppUtils.ProcessPhotoFile(customer.Id_customer,
                    CustomerPhoto, _webHostEnvironment);
                return RedirectToPage("./List");
            }
            if (CustomerPhoto == null)
            {
                return Page();
            }
            return Page();
        }
    }
}
