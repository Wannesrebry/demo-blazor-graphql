using demo_graphql.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services
       .AddGraphQLServer()
       .AddObjectType<DartsQueries>()
       .AddObjectType<Query>();

var app = builder.Build();


app.UseRouting()
    .UseEndpoints(endpoints =>
    {
        endpoints.MapGraphQL();
    });

app.Run();
