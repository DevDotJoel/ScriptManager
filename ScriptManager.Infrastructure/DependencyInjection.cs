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
            services.AddDbContext<ScriptManagerContext>(options => options.UseSqlServer("Server=tcp:joeltest.database.windows.net,1433;Initial Catalog=ScriptManager;Persist Security Info=False;User ID=joel;Password=jJ963679933;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

            return services;
        }
    }
}
