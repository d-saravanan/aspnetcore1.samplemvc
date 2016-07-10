using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ToDo.DAL;

namespace aspnetcoreapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            
            /*app.Run(context =>
            {
                //await Next.Invoke(context);
                //return context.Response.WriteAsync("Hello from ASP.NET Core!");
            });*/
        }
        
        public void ConfigureServices(IServiceCollection collection){
            collection.AddMvc();
            collection.AddSingleton<IToDoRepository,ToDoDAL>();
        }
    }
}