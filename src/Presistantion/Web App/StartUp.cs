using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magpul.Persistence.DbContexts;
using MagpulShop.Domain.Entitys;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Web_app.Services;

namespace Web_app
{
    public class StartUp
    {
        private readonly IConfiguration _configuraion;

        public StartUp(IConfiguration configuration)
        {
            _configuraion = configuration;
        }
        public void ConfigurationServices(IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<MagpulDbContext>();
            services.AddDbContext<MagpulDbContext>(options => options.UseSqlServer(
                _configuraion.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUserService, IUserService>();
            services.AddAutoMapper();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthorization();
            app.UseAuthentication();
            app.UseRouting();

        }
    }
}
