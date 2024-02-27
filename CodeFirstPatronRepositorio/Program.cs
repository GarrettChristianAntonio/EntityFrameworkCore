using CodeFirstPatronRepositorio.Data.DataAccess;
using CodeFirstPatronRepositorio.Data.Entities;
using CodeFirstPatronRepositorio.Repositories;
using CodeFirstPatronRepositorio.Repositories.Interfaces;
using CodeFirstPatronRepositorio.Services;
using CodeFirstPatronRepositorio.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TournamentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // Asegúrate de tener la referencia correcta al ensamblado
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserService, UserService>();


//options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")))
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
