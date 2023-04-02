using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScriptManager.Application.Common.Interfaces;
using ScriptManager.Application.Services;
using ScriptManager.Domain.Shared.Interfaces;
using ScriptManager.Infrastructure.Data;
using ScriptManager.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ScriptManagerContext>(options => options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

            return services;
        }
    }
}
