﻿using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudioPilates.Models;

namespace StudioPilates.Pages
{
    public class LoginModel : PageModel
    {
        public class LoginData
        {
            [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
            [EmailAddress]
            [Display(Name = "E-mail")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
            [DataType(DataType.Password)]
            [Display(Name = "Senha")]
            public string Password { get; set; }

            [Display(Name = "Lembrar de mim")]
            public bool Remember { get; set; }
        }

        private readonly SignInManager<AppUser> _signInManager;

        public LoginModel(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [BindProperty]
        public LoginData Data { get; set; }

        public string ReturnUrl { get; set; }

        //este decorator permite manter um valor entre duas requisições
        //neste caso, esta propriedade temporária está aqui para capturar
        //o valor vindo de outra página, caso tenha.
        //https://www.learnrazorpages.com/razor-pages/tempdata
        [TempData]
        public string ErrorMessage { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // elimina o cookie anterior para garantir um processo de login novo
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            this.ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(Data.Email, Data.Password, Data.Remember, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Tentativa de login inválida. Reveja seus dados de acesso e tente novamente.");
                    return Page();
                }
            }

            return Page();
        }

        public async Task<IActionResult> OnPostLogoutAsync(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}