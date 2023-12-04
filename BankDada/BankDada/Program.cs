using Bank.Service.BL;
using Bank.Service.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Store.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IBankRepository, BankRepository>();
builder.Services.AddScoped<IBankService, BankService>();
//ConfigurationManager configuration = builder.Configuration;
builder.Services.AddDbContext<BankContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("BankConnectionString"));
    
    //option.UseSqlServer(configuration.GetConnectionString("BankConnectionString"));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
///////////////////
///////////////////////
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseAuthorization();

app.MapControllers();

app.Run();
