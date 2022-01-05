using demo_graphql.Mutations;
using demo_graphql.Queries;
using Microsoft.EntityFrameworkCore;
using shared.models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "Open",
        builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services
       .AddGraphQLServer()
       .AddQueryType<ApplicationUserQuery>()
       .AddMutationType<ApplicationUserMutation>();

builder.Services.AddDbContext<DartDbContext>(options =>
{
    options
        .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
        .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
        .EnableSensitiveDataLogging();
});

var app = builder.Build();

app.UseRouting()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapGraphQL();
    });

app.UseCors("Open");

app.Run();
