using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace First_ASP
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddMvc(options => options.EnableEndpointRouting = false);  //add this line    
        }
            
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {        
            // some code removed for brevity        
            // other configurations
            // We will now add the UseStaticFiles() middleware, which allows our app to access our static files.
            app.UseStaticFiles();
            app.UseMvc();    //add this line, replacing the app.UseRouting() and app.UseEndpoints() lines of code    
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    }
}
