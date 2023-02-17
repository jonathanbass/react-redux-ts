using GraphQLDemo.Models;
using GraphQLDemo.Repository;
using GraphQLDemo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IDataRepository, DataRepository>();
builder.Services.AddGraphQLServer()
    .AddQueryType<MovieService>()
    .AddMutationType<MutationType>()
    .AddFiltering();

const string AllowLocalHost = "_allowLocalHost";

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowLocalHost,
        policy =>
        {
            policy.WithOrigins("http://localhost:3000");
            policy.WithHeaders("content-type");
        });
});

var app = builder.Build();

app.UseCors(AllowLocalHost);

app.UseRouting();
app.MapGraphQL();

app.Run();
