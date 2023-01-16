using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Services;
using ConsumeGitHubServices.Infrastructure.Repository;

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DependencyInjection
//Repository
builder.Services.AddScoped<IBranchRepository, BranchRepository>();
builder.Services.AddScoped<IRepositoryRepository, RepositoryRepository>();
builder.Services.AddScoped<IWebhookRepository, WebhookRepository>();
//Services
builder.Services.AddScoped<IBranchService, BranchService>();
builder.Services.AddScoped<IRepositoryService, RepositoryService>();
builder.Services.AddScoped<IWebhookService, WebhookService>();
#endregion



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
