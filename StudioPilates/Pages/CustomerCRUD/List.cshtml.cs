using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudioPilates.Data;
using StudioPilates.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
    //[Authorize(Policy = "isAdmin")]
    public class ListModel : PageModel
    {
        private readonly ILogger<ListModel> _logger;
        private readonly StudioPilatesContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<AppUser> _userManager;

        //public IList<string> EmailsAdmins { get; set; }

        public ListModel(ILogger<ListModel> logger, StudioPilatesContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }


        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync([FromQuery(Name = "q")] string searchTerm, [FromQuery(Name = "o")] int? order = 1)
        {
            var query = _context.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(c => c.Name.ToLower().Contains(searchTerm.ToLower()));
            }
            if (order.HasValue)
            {
                switch (order.Value)
                {
                    case 1:
                        query = query.OrderBy(c => c.Name.ToLower());
                        break;
                    case 2:
                        query = query.OrderBy(c => c.Birth_date);
                        break;
                }
            }
            var queryCount = query;

            Customer = await query.ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);

            if(customer != null)
            {
                //AppUser user = await _userManager.FindByNameAsync(customer.Email);
                //if (user != null)
                //{
                //    await _userManager.RemoveFromRoleAsync(user, "admin");
                //}
                _context.Customers.Remove(customer);
                if(await _context.SaveChangesAsync() > 0)
                {
                    var photoFilePath = Path.Combine(
                        _webHostEnvironment.WebRootPath, 
                        "Photo",
                        customer.Id_customer.ToString("D6") + ".Jpeg");
                    if (System.IO.File.Exists(photoFilePath))
                    {
                        System.IO.File.Delete(photoFilePath);
                    }
                }

            }
            return RedirectToPage("./List");
        }
    }
}
