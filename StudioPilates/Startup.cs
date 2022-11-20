using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudioPilates.Data;
using StudioPilates.Entities;
using StudioPilates.Models;
using StudioPilates.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace StudioPilates
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // habilita a necessidade de consentimento para uso de cookie
                options.CheckConsentNeeded = context => true;
                // adicionar using Microsoft.AspNetCore.Http;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true; //default = false (um usuário requer email único - dois usuários com o mesmo email)
                options.Password.RequireNonAlphanumeric = false; //default = true (não requer alfanumérico)
                options.Password.RequireUppercase = false; //default = true (não requer letra maiúscula)
                options.Password.RequireLowercase = false; //default = true  (não requer minúscula)             
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1); //default = 3 (errar 3 vezes seguidas, so pode tentar após 1 min)
                options.Lockout.MaxFailedAccessAttempts = 3; //default = 5 (errar 3 vezes seguidas, so pode tentar após 1 min)
                options.SignIn.RequireConfirmedAccount = false; //default = false (não precisa de confirmação de conta)
                options.SignIn.RequireConfirmedEmail = false; //default = false (não precisa de confirmação de email)
                options.SignIn.RequireConfirmedPhoneNumber = false; //default = false (não precisa de confirmação de telefone)      
            }).AddEntityFrameworkStores<StudioPilatesContext>()
              .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30); //Expira, caso demore mais que o tempo para requisitar uma pagina
                options.LoginPath = "/Login"; //caminho da pag de login
                options.AccessDeniedPath = "/Login"; //caminho da pag de login qd tentar acessar uma pagina proibida
                options.SlidingExpiration = true; //Renovar o login a cada nova requisição
            });

            services.AddAuthorization();
            //services.AddAuthorization(options =>
            //{
            //    //adiciona uma política de acesso chamada isAdmin
            //    options.AddPolicy("isAdmin", policy =>
            //        policy.RequireRole("admin"));
            //});
            services.AddRazorPages();

            //services.AddRazorPages(options =>
            //{
            //    options.Conventions.AuthorizePage("/Admin", "isAdmin");
            //    options.Conventions.AuthorizeFolder("/CustomerCRUD", "isAdmin");
            //}).AddCookieTempDataProvider(options =>
            //{
            //    options.Cookie.IsEssential = true;
            //});

            services.AddMvc();

            services.AddDbContext<StudioPilatesContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("StudioPilatesContext")));

            //services.Configure<EmailConfiguration>(Configuration.GetSection("EmailConfiguration"));
            ////services.AddSingleton<IEmailSender, EmailSender>();
            //services.AddSingleton<IEmailSender, SendGridSender>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });

            var defaultCulture = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<CultureInfo> { defaultCulture },
                SupportedUICultures = new List<CultureInfo> { defaultCulture }
            };
            app.UseRequestLocalization(localizationOptions);
        }
    }
}

