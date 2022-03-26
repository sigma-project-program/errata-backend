using ErrataManager.Data;
using ErrataManager.Models;
using ErrataManager.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlite<BookContext>("Data Source=ErrorManager.db");

builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<ErrorService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern : "{api}/{service}"
);

app.CreateDbIfNotExists();

app.Run();
