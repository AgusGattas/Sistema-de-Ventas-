using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using SistemaVentas.DAL.Interfaces;
using SistemaVentas.DAL.Implementacion;
using SistemaVentas.BLL.Interfaces;
using SistemaVentas.BLL.Implementacion;


namespace SistemaVentas.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencias(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
            });
        }
    }
}
