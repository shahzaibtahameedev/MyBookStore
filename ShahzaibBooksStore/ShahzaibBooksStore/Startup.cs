using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShahzaibBooksStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc(); to enable MVC in your App
            services.AddControllersWithViews(); //to enable controller with views in your app
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //// First Middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("First MiddleWare");
            //    await next();
            //    await context.Response.WriteAsync("Response of First MiddleWare");
            //});

            //// Second Middleware
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync(" Second MiddleWare");
            //    await next();
            //    await context.Response.WriteAsync(" Response of Second MiddleWare");
            //});

            ////Third MiddleWare
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync(" Third MiddleWare\n");
            //    await next();
            //});


            //Middleware
            app.UseRouting(); 
            
            //Middleware
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute(); //This activates the default route as domain/controller=home/action=index
                //endpoints.MapGet("/", async context =>  //MapGet() is used to map a URL to a particular Resource
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });

            ////Wiil only work for domain/shahzaib
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/shahzaib", async context =>  
            //    {
            //        await context.Response.WriteAsync("Hello Shahzaib");
            //    });
            //});


        }
    }
}
