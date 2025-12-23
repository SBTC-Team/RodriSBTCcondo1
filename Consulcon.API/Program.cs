using Consulcon.API.Services;
using Consulcon.Application.Services;
using Consulcon.Application.Interfaces;
using Consulcon.Domain.Interfaces;
using Consulcon.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// 1. Database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
                       ?? "Server=localhost;Port=3306;Database=sysconsu_asai2;User=admin;Password=admin123";
builder.Services.AddDbContext<ConsulconDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// 2. Generic Repositories & UnitOfWork
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// 3. Application Services
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<ICurrentTenantService, CurrentTenantService>();
builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseAuthorization();

app.MapControllers();

app.Run();
