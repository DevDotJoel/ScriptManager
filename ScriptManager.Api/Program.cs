using Microsoft.EntityFrameworkCore;
using ScriptManager.Application.Common.Interfaces;
using ScriptManager.Application.Common.Mapping;
using ScriptManager.Application.Services;
using ScriptManager.Domain.Common.Interfaces;
using ScriptManager.Infrastructure.Data;
using ScriptManager.Infrastructure.UnitOfWork;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ScriptManagerContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IScriptService, ScriptService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper((sp, cfg) => cfg.AddProfile(typeof(ScriptMapping)), Array.Empty<Assembly>());
var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
