using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Services;
using CleanMovie.Infrastructure;
using CleanMovie.Infrastructure.MappingConfig;
using CleanMovie.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//Register configurataion



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




//Add Database Service

builder.Services.AddDbContext<MovieDbContext>(opt => opt.UseSqlServer(
	builder.Configuration.GetConnectionString("DefaultConnection")
	,b => b.MigrationsAssembly("CleanMovie.Infrastructure"))
);

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddAutoMapper(typeof(MappingDbToModelProfile));

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
