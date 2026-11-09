using Microsoft.EntityFrameworkCore;
using Raceday_app.Data;

var builder = WebApplication.CreateBuilder(args);

// Register API controllers
builder.Services.AddControllers();

// Register SQL Server database
builder.Services.AddDbContext<RaceDayContext>(options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("RaceDay")));

// Register Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Map API controllers
app.MapControllers();

app.Run();