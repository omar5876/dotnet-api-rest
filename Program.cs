//using to work with entity framework

using Microsoft.EntityFrameworkCore;
using backendDotnet.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//connection with SQL Server Express
const string CONNECTION_DB = "ApiDotnet";
var connectionString = builder.Configuration.GetConnectionString(CONNECTION_DB);

//context
builder.Services.AddDbContext<ApiDotnetContext>(options => options.UseSqlServer(connectionString));

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
