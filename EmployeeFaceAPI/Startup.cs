using EmployeeFace.BusinessLogic.MapperProfile;
using EmployeeFace.DataAccess.Model;
using EmployeeFace.DataAccess.Repository;
using EmployeeFace.Service.ServiceCollection.Face;
using EmployeeFace.Service.ServiceCollection.PersonGroup;
using EmployeeFace.Service.ServiceCollection.PersonGroupPerson;
using EmployeeFaceAPI.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;

namespace EmployeeFaceAPI
{
    public class Startup
    {
        private readonly string AllowedOrigin = "allowedOrigin";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            services.Scan(scan => scan
            .FromApplicationDependencies(a => a.FullName.StartsWith("EmployeeFace"))
            .AddClasses(true)
            .AsMatchingInterface((service, filter) => filter.Where(implementation => implementation.Name.Equals($"I{service.Name}", StringComparison.OrdinalIgnoreCase)))
            .WithTransientLifetime());
            services.AddAutoMapper(typeof(MainProfile).GetTypeInfo().Assembly);
            services.AddControllers();

            services.AddHttpClient();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EmployeeFaceAPI", Version = "v1" });
            });

            services.AddDbContext<EmployeeDBContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("EmployeeDBContext")));
            services.AddTransient<IEmployeeDAO, EmployeeDAO>();
            services.AddHttpClient<IPersonGroupService, PersonGroupService>();
            services.AddHttpClient<IPersonGroupPersonService, PersonGroupPersonService>();
            services.AddHttpClient<IFaceService, FaceService>();

            services.AddCors(option =>
            {
                option.AddPolicy("allowedOrigin",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
                    );
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
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EmployeeFaceAPI v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("AllowAllHeaders");

            app.UseAuthorization();
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
