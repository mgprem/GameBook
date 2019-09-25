using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LHBOL;
using LHBLL;
using LHDAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace LHUI
{
    public class Startup
    {
        IConfiguration Configuration { get; }
        public Startup(IConfiguration _Configuration)
        {
            Configuration = _Configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.RegisterBLLServices();
            #region Business Logic Layer Services
            services.AddTransient<IGamebookBs, GameBookBs>();
            #endregion
            #region Data Access layer Services
            services.AddTransient<IGamebookDb, GamebookDb>();
            #endregion
            services.AddDbContext<LHDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("GBConnection")));
           // services.AddDbContext<LHDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("LocalConnection")));
            
            services.AddIdentity<User,IdentityRole>().
                AddEntityFrameworkStores<LHDbContext>().
                AddDefaultTokenProviders();

            var policy = new AuthorizationPolicyBuilder()
                             .RequireAuthenticatedUser()
                             .Build();
            services.AddMvc(x => x.Filters.Add(new AuthorizeFilter(policy)));
           // services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
            app.UseDeveloperExceptionPage();
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvc(routes => //configure
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Gamebooks}/{action=Index}/{id?}");
            });
        }
    }
}
