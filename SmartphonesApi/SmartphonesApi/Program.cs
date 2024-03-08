using Innovt.Data.DataSources;
using Innovt.Domain.Core.Repository;
using SmartphonesApi.Domain.Smartphone;
using SmartphonesApi.Platform.Application.Smartphone;
using SmartphonesApi.Platform.Infrastructure.Database.Context;
using SmartphonesApi.Platform.Infrastructure.Database.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ISmartphoneAppService, SmartphoneAppService>();
builder.Services.AddTransient<ISmartphoneRepository, SmartphoneRepository>();
builder.Services.AddTransient<IExtendedUnitOfWork, DataContext>();
builder.Services.AddTransient<IDataSource>(_ => new DefaultDataSource(builder.Configuration, "ApiConnectionString", Innovt.Data.Model.Provider.PostgreSqL));

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
