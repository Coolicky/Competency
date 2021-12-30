using Autofac;
using Autofac.Extensions.DependencyInjection;
using Competency.Api.Extensions;
using Competency.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

//Autofac registration
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(cb =>
{
  cb.RegisterModule(new DefaultInfrastructureModule());
});

// Add services to the container.
services.AddMicrosoftIdentityAuthentication(config);
services.AddControllers();
services.AddSwaggerServices(config);
services.ConfigureCors();

services.AddSqlServerDbContext(config["DatabaseConnection"]);



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(c =>
  {
    c.OAuthClientId(builder.Configuration["AzureAd:OpenIdClientId"]);
    c.OAuthClientSecret(builder.Configuration["AzureAd:ClientSecret"]);
    c.OAuthUseBasicAuthenticationWithAccessCodeGrant();
  });
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(policy =>
{
  policy.AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("https://localhost:7011")
    .WithOrigins("https://localhost:7223");
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
