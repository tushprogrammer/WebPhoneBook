﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebPhoneBook
{
    public class Startup
    {
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSpaStaticFiles();
            services.AddMvc();
        }

        public async void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            Console.WriteLine("текст о запуске конфига");
            

            app.UseMvc(
                run =>
                {
                    run.MapRoute(
                        name: "default",
                        template: "{controller=Book}/{action=index}"
                        );
                });


        }
    }
}
