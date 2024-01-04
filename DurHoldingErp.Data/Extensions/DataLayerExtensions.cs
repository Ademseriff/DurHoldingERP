using DurHoldingErp.Data.Repositories.Abstractions;
using DurHoldingErp.Data.Repositories.Concretes;
using DurHoldingErp.Data.UnitOfWorks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Data.Extensions
{
    //dependcy injection sınıfımımızı oluşturduk bu katman için 
    public static class DataLayerExtensions
    {
        //burası ıservicecollection ekleme işi bunun bir servis olacağını belli ediyoruz program.cs eklemek için
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config) {
            //addscoped olarak ekleme olayı.
            services.AddScoped (typeof(IRepository<>),typeof(Repository<>));


            //unit of works yapısınının depency injection eklemesi =>Unit of Work yapılan işlemlerin bir birim üzerinden ele alıp, bu olayları saklayan daha sonra ise toplu halde kaydedilmesi, bir hata ile karşılaşıldığında geri alınması ve ya iptal edilmesini sağlamaktır
            services.AddScoped<IUnitOfWork, UnitOfWork>();
          

            return services;
        }

    }
}
