using Microsoft.Extensions.DependencyInjection;
using Quot.Engine.Db;
using Quot.Engine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quot.Engine.Services
{
    public static class DependencyInjection
    {
        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddTransient<IDbContext, Shakespeare_WorksContext>();

            services.AddTransient<IAuthorService, AuthorService>();

            services.AddTransient<ITextService, TextService>();

        }
    }
}
