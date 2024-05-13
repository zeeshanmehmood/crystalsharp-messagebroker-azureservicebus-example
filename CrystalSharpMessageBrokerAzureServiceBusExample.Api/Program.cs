using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CrystalSharp;
using CrystalSharp.Messaging.AzureServiceBus.Configuration;
using CrystalSharp.Messaging.AzureServiceBus.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string azureServieBusConnection = builder.Configuration.GetSection("AppSettings:AzureServiceBusConnection").Value;
AzureServiceBusSettings messageBrokerSettings = new(azureServieBusConnection);

CrystalSharpAdapter.New(builder.Services)
    .AddAzureServiceBus(messageBrokerSettings)
    .CreateResolver();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
