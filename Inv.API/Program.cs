using Inv.Models.ModelsDB;
using Inv.Services.ProductsService;
using Inv.Services.CategoriesService;
using Inv.Services.SupliersService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<InvContextDB>(
    option=> option.UseSqlServer(builder.Configuration.GetConnectionString("InvDbCon"))
    );

builder.Services.AddScoped<ProductsProvider>();
builder.Services.AddScoped<CategoriesProvider>();
builder.Services.AddScoped<SupliersProvider>();
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
