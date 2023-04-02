using Microsoft.Extensions.DependencyInjection;
using ScriptManager.Application.Common.Interfaces;
using ScriptManager.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ScriptManager.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IScriptService, ScriptService>();
            return services;
        }
    }
}
