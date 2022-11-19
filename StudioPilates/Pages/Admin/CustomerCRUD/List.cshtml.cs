using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudioPilates.Data;
using StudioPilates.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudioPilates.Pages.CustomerCRUD
{
   
    public class ListModel : PageModel
    {
        private const int pageSize = 12;
        //private readonly ILogger<ListModel> _logger;
        private readonly StudioPilatesContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public IList<string> EmailsAdmins { get; set; }
        public int CurrentPage { get; set; }
        public int NumberPages { get; set; }

        public ListModel(StudioPilatesContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IWebHostEnvironment webHostEnvironment)
        {
            this._context = context;
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._webHostEnvironment = webHostEnvironment;
        }

        public IList<Customer> Customer { get; set; }

        public async Task OnGetAsync([FromQuery(Name = "q")] string searchTerm, [FromQuery(Name = "o")] int? order = 1, [FromQuery(Name = "p")] int? page = 1)
        {
            Customer = await _context.Customers.ToListAsync();

            EmailsAdmins = (await _userManager.GetUsersInRoleAsync("admin")).Select(x => x.Email).ToList();

            this.CurrentPage = page.Value;

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
            int customerQuantity = queryCount.Count();
            this.NumberPages = Convert.ToInt32(Math.Ceiling(customerQuantity * 1M / pageSize));
            query = query.Skip(pageSize * (this.CurrentPage - 1)).Take(pageSize);

            Customer = await query.ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
                if (await _context.SaveChangesAsync() > 0)
                {
                    var photoFilePath = Path.Combine(
                        _webHostEnvironment.WebRootPath,
                        "Photo",
                        customer.Id_customer.ToString("D6") + ".Jpeg");
                    if (System.IO.File.Exists(photoFilePath))
                    {
                        System.IO.File.Delete(photoFilePath);
                    }
                    AppUser user = await _userManager.FindByNameAsync(customer.Email);
                    if (user != null) await _userManager.DeleteAsync(user);
                }

            }
            return RedirectToPage("./List");
        }
        public async Task<IActionResult> OnPostDelAdminAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);

            if (customer != null)
            {
                AppUser user = await _userManager.FindByNameAsync(customer.Email);
                if (user != null)
                {
                    await _userManager.RemoveFromRoleAsync(user, "admin");
                }
            }
            return RedirectToPage("./List");
        }
        public async Task<IActionResult> OnPostSetAdminAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);

            if (customer != null)
            {
                AppUser user = await _userManager.FindByNameAsync(customer.Email);
                if (user != null)
                {
                    if (!await _roleManager.RoleExistsAsync("admin"))
                        await _roleManager.CreateAsync(new IdentityRole("admin"));

                    await _userManager.AddToRoleAsync(user, "admin");
                }
            }
            return RedirectToPage("./List");
        }
    }
}
