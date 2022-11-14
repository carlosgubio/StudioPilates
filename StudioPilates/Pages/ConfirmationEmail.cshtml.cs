using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using StudioPilates.Models;

namespace StudioPilates.Pages
{
    public class ConfirmationEmailModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;

        public ConfirmationEmailModel(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public string StatusMessage { get; set; }
        public bool ConfirmedEmail { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Não foi possível encontrar o usuário com ID '{userId}'.");
            }

            token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token));
            var result = await _userManager.ConfirmEmailAsync(user, token);
            ConfirmedEmail = result.Succeeded;
            StatusMessage = ConfirmedEmail ? "E-mail confirmado com sucesso!" :
                "Ocorreu um erro ao confirmar seu e-mail.";
            return Page();
        }
    }
}