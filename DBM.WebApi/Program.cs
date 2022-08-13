using DBM.BLL.Interfaces.Services;
using DBM.BLL.Services;
using DBM.DAL;
using DBM.DAL.Data;
using DBM.DAL.Data.Repositories;
using DBM.DAL.Interfaces;
using DBM.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("Default");
    options.UseSqlServer(connectionString);
});

builder.Services.AddTransient<IMovieRepository, MovieRepository>();

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddTransient<IMovieService, MovieService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseStaticFiles();

app.MapControllers();

app.Run();

