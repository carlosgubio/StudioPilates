using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using StudioPilates.Data;
using StudioPilates.Models;
using StudioPilates.Services;

namespace StudioPilates.Pages
{
    public class RecoverPasswordModel : PageModel
    {
        private UserManager<AppUser> _userManager;
        private readonly IEmailSender _emailSender;

        public class DataEmail
        {
            [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
            [EmailAddress]
            [Display(Name = "E-mail")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
        }

        [BindProperty]
        public DataEmail Data { get; set; }

        public RecoverPasswordModel(StudioPilatesContext context,
            UserManager<AppUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(Data.Email);
                if (user != null)
                {
                    string token = await _userManager.GeneratePasswordResetTokenAsync(user);
                    token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
                    var urlResetarSenha = Url.Page("/RedefinirSenha",
                        null, new { token }, Request.Scheme);

                    StringBuilder msg = new StringBuilder();
                    msg.Append("<h1>StudioPilatese :: Recuperação de Senha</h1>");
                    msg.Append($"<p>Por favor, redefina sua senha <a href='{HtmlEncoder.Default.Encode(urlResetarSenha)}'>clicando aqui</a>.</p>");
                    msg.Append("<p>Atenciosamente<br>Equipe de Suporte Studio Pilates</p>");
                    await _emailSender.SendEmailAsync(user.Email, "Recuperação de Senha", "", msg.ToString());
                    return RedirectToPage("/EmailRecuperacaoEnviado");
                }
                else
                {
                    //Não é seguro informar ao usuário que o e-mail informado 
                    return RedirectToPage("/EmailRecuperacaoEnviado");
                    //ModelState.AddModelError("Dados.Email", "Nenhum usuário foi encontrado com este e-mail. " +
                    //    "Confira e tente novamente.");                    
                }
            }

            return Page();
        }
    }
}