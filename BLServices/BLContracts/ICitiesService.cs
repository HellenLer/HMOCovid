using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLContracts
{
    public interface ICitiesService
    {
        CitiesDTO GetCity(int id);
        List<CitiesDTO> GetAllCities();

        CitiesDTO AddCity(CitiesDTO citiesDTO);

        int GetCityByName(string city);

    }
}
