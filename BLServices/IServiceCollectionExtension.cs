using BLServices.BLContracts;
using BLServices.BLService;
using BLServices.Profiles;
using DAL;
using DAL.DalContracts;
using DAL.DALRepositories;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLServices
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection collection, IConfiguration config)
        {


            #region Add mappers
            collection.AddAutoMapper(typeof(AdressProfile));
            collection.AddAutoMapper(typeof(CitiesProfile));
            collection.AddAutoMapper(typeof(CompanyProfile));
            collection.AddAutoMapper(typeof(DateVaccineProfile));
            collection.AddAutoMapper(typeof(MembersDetailsProfile));
            collection.AddAutoMapper(typeof(SickDateProfile));
            collection.AddAutoMapper(typeof(StreetProfile));
            #endregion

            #region Services
            collection.AddScoped<IAddressService, AddressService>();
            collection.AddScoped<ICitiesService, CitiesService>();
            collection.AddScoped<ICompanyService, CompanyService>();
            collection.AddScoped<IDateVaccinesService, DeteVaccineService>();
            collection.AddScoped<IMembersDetailsService, MembersDetailsService>();
            collection.AddScoped<ISickDateService, SickDateService>();
            collection.AddScoped<IStreetService, StreetService>();
            #endregion 

            collection.AddRepositories(config);

            return collection;
        }
    }
}
