using GraphQLApplication.EmployeeService;
using GraphQLApplication.GraphQL;
using GraphQLApplication.Models;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQLApplication
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IEmployeeService,
                        GraphQLApplication.EmployeeService.EmployeeService>();
            services.AddScoped<DatabaseContext>();

            services.AddScoped<Query>();
            services.AddScoped<GraphQLApplication.GraphQL.Mutuation>();
            services.AddGraphQL(c => SchemaBuilder.New().AddServices(c)
                                .AddType<GraphQLTypes>()
                                .AddQueryType<Query>()
                                .AddMutationType<Mutuation>()
                                .Create());

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions
                {
                    QueryPath = "/api",
                    Path = "/playground"
                });
            }
            app.UseGraphQL("/api");
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
