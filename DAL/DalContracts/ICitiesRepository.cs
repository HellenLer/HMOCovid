using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalContracts
{
    public interface ICitiesRepository
    {
        public List<City> GetAllCities();
        public City GetCity(int id);
        public City Addcity(City city);
        public int GetCityByName(string city);

    }
}
