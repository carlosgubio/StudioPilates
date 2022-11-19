//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using System.Text.Encodings.Web;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.WebUtilities;
//using StudioPilates.Data;
//using StudioPilates.Models;
//using StudioPilates.Services;

//namespace StudioPilates.Pages
//{
//    public class NewCustomerModel : PageModel
//    {
//        public class Passwords
//        {
//            [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
//            [StringLength(16, ErrorMessage = "O campo \"{0}\" deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)] // minimo 6, maximo 16 caracteres
//            [DataType(DataType.Password)]
//            [Display(Name = "Senha")]
//            public string Password { get; set; }

//            [Required(ErrorMessage = "O campo \"{0}\" é de preenchimento obrigatório.")]
//            [DataType(DataType.Password)]
//            [Display(Name = "Confirmação da Senha")]
//            [Compare("Password", ErrorMessage = "A confirmação da senha não confere com a senha informada.")]
//            public string ConfirmPassword { get; set; }
//        }

//        private StudioPilatesContext _context;
//        //private readonly IEmailSender _emailSender;
//        private UserManager<AppUser> _userManager;
//        private RoleManager<IdentityRole> _roleManager;

//        public NewCustomerModel(StudioPilatesContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
//        {
//            _context = context;
//            //_emailSender = emailSender; //envio de email de confirmação
//            _userManager = userManager; // manipulação para o tipo usuário
//            _roleManager = roleManager; // gerenciamento de perfis
//        }

//        [BindProperty]
//        public Customer Customer { get; set; }

//        [BindProperty]
//        public Passwords UserPasswords { get; set; }

//        public IActionResult OnGet()
//        {
//            return Page();
//        }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            //cria um novo objeto Cliente
//            var customer = new Customer();
//            customer.Address = new Address();

//            //novos clientes sempre iniciam com essa situação
//            customer.Status = Customer.CustomerStatus.Cadastrado;

//            var userPasswords = new Passwords();
//            if (!await TryUpdateModelAsync(userPasswords, userPasswords.GetType(), nameof(userPasswords)))
//                return Page();

//            //tenta atualizar o novo objeto com os dados oriundos do formulário
//            if (await TryUpdateModelAsync(customer, Customer.GetType(), nameof(Customer)))
//            {
//                //verifica se o perfil de usuário "cliente" existe
//                if (!await _roleManager.RoleExistsAsync("customer"))
//                {
//                    await _roleManager.CreateAsync(new IdentityRole("customer"));
//                }

//                //verifica se já existe um usuário com o e-mail informado
//                var existingUser = await _userManager.FindByEmailAsync(customer.Email);
//                if (existingUser != null)
//                {
//                    //adiciona um erro na propriedade Email do cliente para que o campo apresente o erro no formulário
//                    ModelState.AddModelError("Customer.Email", "Já existe um cliente cadastrado com este e-mail.");
//                    return Page();
//                }

//                //cria o objeto usuário Identity e adiciona ao perfil "cliente"
//                var user = new AppUser()
//                {
//                    UserName = customer.Email,
//                    Email = customer.Email,
//                    PhoneNumber = customer.Phone,
//                    Name = customer.Name
//                };

//                //cria usuário no banco de dados
//                var result = await _userManager.CreateAsync(user, userPasswords.Password);

//                //se a criação do usuário Identity foi bem sucedida
//                if (result.Succeeded)
//                {
//                    //associa o usuário ao perfil "cliente"
//                    await _userManager.AddToRoleAsync(user, "customer");

//                    //adiciona o novo objeto cliente ao contexto de banco de dados atual e salva no banco de dados
//                    _context.Customers.Add(customer);
//                    int affected = await _context.SaveChangesAsync();
//                    //se salvou o cliente no banco de dados
//                    if (affected > 0)
//                    {
//                        //envia uma mensagem ao usuário para que ele confirme seu e-mail	
//                        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
//                        token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(token));
//                        var urlConfirmationEmail = Url.Page("/ConfirmationEmail", null,
//                            new { userId = user.Id, token }, Request.Scheme);
//                        StringBuilder msg = new StringBuilder();
//                        msg.Append("<h1>Instituto Movimento Consciente :: Confirmação de E-mail</h1>");
//                        msg.Append($"<p>Por favor, confirme seu e-mail " +
//                            $"<a href='{HtmlEncoder.Default.Encode(urlConfirmationEmail)}'>clicando aqui</a>.</p>");
//                        msg.Append("<p>Atenciosamente,<br>Equipe de Suporte Instituto Movimento Consciente!</p>");
//                        await _emailSender.SendEmailAsync(user.Email, "Confirmação de E-mail", "", msg.ToString());

//                        return RedirectToPage("/RegistrationPerformed");
//                    }
//                    else
//                    {
//                        //exclui o usuário Identity criado
//                        await _userManager.DeleteAsync(user);
//                        ModelState.AddModelError("Customer", "Não foi possível efetuar o cadastro. Verifique os dados " +
//                            "e tente novamente. Se o problema persistir, entre em contato conosco.");
//                        return Page();
//                    }
//                }
//                else
//                {
//                    ModelState.AddModelError("Customer.Email", "Não foi possível criar um usuário com este endereço de e-mail. " +
//                        "Use outro endereço de e-mail ou tente recuperar a senha deste.");
//                }
//            }
//            return Page();
//        }
//    }
//}