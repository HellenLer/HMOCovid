using DAL.DalContracts;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALRepositories
{
    public class CitiesRepository : ICitiesRepository
    {
        HMOContext context;
        public CitiesRepository(HMOContext context)
        {
            this.context = context;
        }

        public City Addcity(City city)
        {
            context.Add(city);
            context.SaveChanges();
            return city;
        }

        public List<City> GetAllCities()
        {
            return context.Cities.OrderBy(c => c.City1).ToList();
        }

        

        public City GetCity(int id)
        {
            return context.Cities.AsQueryable()
                 .Where(c => c.CityKey == id).FirstOrDefault();
        }

        public int GetCityByName(string city)
        {
            return context.Cities.FirstOrDefault(c => c.City1 == city)?.CityKey ?? 0;
        }
    }
}
