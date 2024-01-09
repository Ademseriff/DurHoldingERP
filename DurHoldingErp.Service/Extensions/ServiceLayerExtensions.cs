using DurHoldingErp.Data.Repositories.Abstractions;
using DurHoldingErp.Data.Repositories.Concretes;
using DurHoldingErp.Data.UnitOfWorks;
using DurHoldingErp.Service.Services.Abstractions;
using DurHoldingErp.Service.Services.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            ////addscoped olarak ekleme olayı.
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


            ////unit of works yapısınının depency injection eklemesi =>Unit of Work yapılan işlemlerin bir birim üzerinden ele alıp, bu olayları saklayan daha sonra ise toplu halde kaydedilmesi, bir hata ile karşılaşıldığında geri alınması ve ya iptal edilmesini sağlamaktır
            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IUsersService, UsersService>();
            return services;
        }
    }
}
