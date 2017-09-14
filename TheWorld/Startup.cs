using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace TheWorld
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            //Sept3, commented out by RC
            /*
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            */

            //Sept3, open file "TheWorld.csproject" and added the following
            //< PackageReference Include = "Microsoft.AspnetCore.StaticFiles" Version = "1.1.2" />
            //Sept3, added by RC
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
