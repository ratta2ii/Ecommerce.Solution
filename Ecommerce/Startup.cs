  
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ecommerce.Models;  // This enables passing in the EcommerceContext model 
using Microsoft.AspNetCore.Identity;

namespace Ecommerce
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json");  // Connection string in this file
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();

      services.AddSession(options => {
        options.IdleTimeout = System.TimeSpan.FromMinutes(30);
        options.Cookie.HttpOnly = true;
        // Make the session cookie essential
        options.Cookie.IsEssential = true;
      });

      services.AddEntityFrameworkMySql()
        .AddDbContext<EcommerceContext>(options => options   // Update Context to project name
        .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

        // services.AddIdentity<ApplicationUser, IdentityRole>()
        //     .AddEntityFrameworkStores<EcommerceContext>()
        //     .AddDefaultTokenProviders();

        // services.Configure<IdentityOptions>(options =>
        // {
        //     options.Password.RequireDigit = false;
        //     options.Password.RequiredLength = 0;
        //     options.Password.RequireLowercase = false;
        //     options.Password.RequireNonAlphanumeric = false;
        //     options.Password.RequireUppercase = false;
        //     options.Password.RequiredUniqueChars = 0;
        // });
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseStaticFiles();

      app.UseDeveloperExceptionPage();

      // app.UseAuthentication();

      app.UseSession();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });

      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Something went wrong!");
      });
    }
  }
}