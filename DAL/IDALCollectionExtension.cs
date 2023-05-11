using DAL.DalContracts;
using DAL.DALRepositories;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DAL.DALUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class IDALCollectionExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection collection, IConfiguration config)
        {
           
            #region Add repositories
            collection.AddScoped<IAddressRepository, AddressRepository>();
            collection.AddScoped<ICitiesRepository, CitiesRepository>();
            collection.AddScoped<ICompanyRepository, CompanyRepository>();
            collection.AddScoped<IDateVaccinesRepository, DateVaccinesRepository>();
            collection.AddScoped<IMembersDetaisRepository, MembersDetailsRepository>();
            collection.AddScoped<ISickDateRepository, SickDateRepository>();
            collection.AddScoped<IStreetRepository, StreetRepository>();
            #endregion

            string? str = config.GetConnectionString("CovidHMO");
            string connString = ReplaceWithCurrentLocation(str);
            collection.AddDbContext<HMOContext>(options => options.UseSqlServer(connString));

            return collection;
        }

        public static string ReplaceWithCurrentLocation(string connStr)
        {
            string str = AppDomain.CurrentDomain.BaseDirectory;
            string directryAboveBin = str.Substring(0, str.IndexOf("\\bin"));
            string twoDirectoriesAboveBin = directryAboveBin.Substring(0, directryAboveBin.LastIndexOf("\\"));
            connStr = string.Format(connStr, twoDirectoriesAboveBin);
            return connStr;
        }
    }
}
