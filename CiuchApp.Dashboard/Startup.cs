using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CiuchApp.Dashboard.Services;
using CiuchApp.DataAccess;
using CiuchApp.DataAccess.AspNetIdentity;
using Microsoft.Extensions.Logging;
using Serilog;
using CiuchApp.Settings;
using CiuchApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CiuchApp.Dashboard
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            });

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<ICiuchAppSettings, CiuchAppSettings>();
            services.AddTransient<ICrudService<BusinessTrip>, BusinessTripService>();
            services.AddTransient<ICrudService<Piece>, PieceService>();
            services.AddTransient<ICrudService<SizeAmountPair>, SizeAmountPairService>();
            services.AddTransient<IDropdownServices, DropdownServices>();

            AddTransientDropdownService<Country>(services);
            AddTransientDropdownService<City>(services);
            AddTransientDropdownService<Season>(services);
            AddTransientDropdownService<Currency>(services);
            AddTransientDropdownService<Color>(services);
            AddTransientDropdownService<TopCategory>(services);
            AddTransientDropdownService<MainCategory>(services);
            AddTransientDropdownService<Group>(services);
            AddTransientDropdownService<Component>(services);
            AddTransientDropdownService<CountryOfOrigin>(services);
            AddTransientDropdownService<Supplier>(services);
            AddTransientDropdownService<CodeCn>(services);
            AddTransientDropdownService<Set>(services);
            AddTransientDropdownService<ColorName>(services);
            AddTransientDropdownService<Size>(services);

            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizePage("/Account/Login");
            }); ;
        }

        private static void AddTransientDropdownService<T>(IServiceCollection services) where T : DropDownValueBase
        {
            services.AddTransient<ICrudService<T>, DropdownService<T>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddSerilog();

            if (env.IsDevelopment())
            {
              app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }

    }
}
