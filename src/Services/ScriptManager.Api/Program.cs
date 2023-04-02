using ScriptManager.Application;
using ScriptManager.Application.Common.Mapping;
using ScriptManager.Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplication().AddInfrastructure();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper((sp, cfg) => cfg.AddProfile(typeof(ScriptMapping)), Array.Empty<Assembly>());
builder.Services.AddCors(o => o.AddPolicy("react", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("react");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
