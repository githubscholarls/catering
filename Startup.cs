using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using catering.Entity;
using Microsoft.EntityFrameworkCore;
using catering.ModelDto;
using catering.Interface;
using AutoMapper;
using System;
using catering.Models;
using Microsoft.AspNetCore.Identity;
using catering.CustomerMiddlewares;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using catering.CustomAuthorization;

namespace catering
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
            services.AddControllersWithViews(config=>
            {
                //配置授权，检查用户是否能通过身份验证
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            }).AddRazorRuntimeCompilation();

            //扫描当前作用域的所有程序集里面扫描Atuomapper的配置文件
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDbContext<dbContext>(config =>
            {
                config.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<user>();
            services.AddIdentity<user, IdentityRole>().AddErrorDescriber<CustomIdentityErrorDescriber>().AddEntityFrameworkStores<dbContext>();

            //policy策略授权
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Teenager", policy =>
                    policy.Requirements.Add(new AdultPolicyRequirement(12)));
                options.AddPolicy("Adult", policy =>
                    policy.Requirements.Add(new AdultPolicyRequirement(18)));
            });
            
            services.AddSingleton< IAuthorizationHandler,AdultAuthorizationHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //对用户进行身份验证，用作认证
            app.UseAuthentication();
            app.UseRouting();
            //明确用户是否有某个权限，用作授权
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{ReturnUrl?}");
            });
            
        }
    }
}
