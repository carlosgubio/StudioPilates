using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace StudioPilates.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly StudioPilatesContext _context;

        public IList<Models.Customer> Customers;

        //public IndexModel(ILogger<IndexModel> logger, StudioPilatesContext context)
        //{
        //    _logger = logger;
        //    _context = context;
        //}

        //public async Task OnGetAsync()
        //{
        //    Customers = await _context.Customers.ToListAsync<Customer>();
        //}
        private readonly IWebHostEnvironment _webHostEnvironment;

        public string CaminhoImagem { get; set; }

        //[BindProperty]
        //[Display(Name = "Imagem da Logo")]
        //[Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
        //public IFormFile ImagemLogo { get; set; }

        public IndexModel(ILogger<IndexModel> logger, StudioPilatesContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            CaminhoImagem = "~/img/LOGO-IMC-0002.jpg";
        }

    }

}
