using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using StudioPilates.Models;

namespace StudioPilates.Pages
{
    public class RedefinePasswordModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;

        public RedefinePasswordModel(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public PasswordResetData Data { get; set; }

        public class PasswordResetData
        {
            [Required(ErrorMessage = "O campo \"{0}\" � de preenchimento obrigat�rio.")]
            [EmailAddress]
            public string Email { get; set; }

            [Required(ErrorMessage = "O campo \"{0}\" � de preenchimento obrigat�rio.")]
            [StringLength(100, ErrorMessage = "O campo \"{0}\" deve ter no m�nimo {2} e no m�ximo {1} caracteres.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirma��o de Senha")]
            [Compare("Senha", ErrorMessage = "A senha e a confirma��o de senha est�o divergentes.")]
            public string ConfirmPassword { get; set; }

            public string Token { get; set; }
        }

        public IActionResult OnGet(string token = null)
        {
            if (token == null)
            {
                return BadRequest("Um token deve ser fornecido para redefinir a senha.");
            }
            else
            {
                Data = new PasswordResetData
                {
                    Token = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token))
                };
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Data.Email);
            if (user == null)
            {
                // N�o revela que o usu�rio n�o existe
                return RedirectToPage("/ConfirmationResetPassword");
            }

            var result = await _userManager.ResetPasswordAsync(user, Data.Token, Data.Password);
            if (result.Succeeded)
            {
                return RedirectToPage("./ConfirmationResetPassword");
            }

            foreach (var erro in result.Errors)
            {
                ModelState.AddModelError(string.Empty, erro.Description);
            }

            return Page();
        }
    }
}