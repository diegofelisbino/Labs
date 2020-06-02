using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CheckList.Api
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
            services.AddControllers();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = $"CheckList API ",
                        Version = "v1",
                        Description = "API de controle de Serviços REST para a CheckList de Sintomas.",
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "Santos Brasil Participações - Tecnologia da Informação - Sistemas",
                            Email = "diego.felisbino@santosbrasil.com.br",
                            Url = new Uri("https://www.santosbrasil.com.br")
                        }
                    });
                options.AddSecurityDefinition(
                    "bearer",
                    new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                    {
                        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                        Description = "Autenticação baseada em Json Web Token (JWT)",
                        Name = "Authorization",
                        Type = Microsoft.OpenApi.Models.SecuritySchemeType.OpenIdConnect
                    });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.CustomOperationIds(opid =>
                {
                    return $"{opid.ActionDescriptor.RouteValues["controller"]}_{opid.ActionDescriptor.RouteValues["action"]}";
                });
                options.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
           {
               c.RoutePrefix = "swagger";               
               c.SwaggerEndpoint("/swagger/v1/swagger.json", "CheckList API");
           });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
