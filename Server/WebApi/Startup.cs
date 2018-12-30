using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReactTemplate.Data.Contexts;
using ReactTemplate.Data.Data;
using ReactTemplate.WebApi.Services;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace ReactTemplate.WebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvcCore()
                .AddApiExplorer()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFormatterMappings()
                .AddJsonFormatters();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "React Template", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddDbContext<ExampleContext>(options => options.UseInMemoryDatabase("mem"));
            services.AddScoped<IExampleData, ExampleData>();
            services.AddScoped<IExampleService, ExampleService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "React Template");
                });
            }
            else
            {
                app.UseHsts();
            }
            app.UseMvc();
            var DefaultFile = new DefaultFilesOptions();
            DefaultFile.DefaultFileNames.Clear();
            DefaultFile.DefaultFileNames.Add("index.html");
            app.UseDefaultFiles(DefaultFile);
            app.UseStaticFiles();
            app.UseHttpsRedirection();
        }
    }
}
