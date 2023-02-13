using GraphQL.ExtensionMethods;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConnectToSQL(builder.Configuration);
builder.Services.ConnectGraphQLServer();
builder.Services.ConfigureAppService();

var app = builder.Build();

app.MapGraphQL();
app.MapGraphQLVoyager();

app.Run();
