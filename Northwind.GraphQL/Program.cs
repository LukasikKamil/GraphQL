using Northwind.GraphQL; // Query
using ALLinONE.Shared; // AddNorthwindContext extension method

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddNorthwindContext();

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<NorthwindContext>()
    .AddQueryType<Query>();

var app = builder.Build();

app.MapGet("/", () => "Navigate to: https://localhost:5111/graphql");

app.MapGraphQL();

app.Run();
