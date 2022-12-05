using Microsoft.EntityFrameworkCore;
using UniversityApiBackendoReplica.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Connecting to SQL
var connectionName = "DefaultConnection";
var connestionString = builder.Configuration.GetConnectionString(connectionName);

// Add context to the builder services using the connection
builder.Services.AddDbContext<UniversityDbContext>(options => options.UseSqlServer(connestionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
