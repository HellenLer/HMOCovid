using AutoMapper;
using BLServices.BLContracts;
using DAL.DalContracts;
using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLServices.BLService
{
    public class CitiesService:ICitiesService
    {
        ICitiesRepository citiesRepository;
        IMapper mapper;
        public CitiesService(ICitiesRepository citiesRepository, IMapper mapper)
        {
            this.citiesRepository = citiesRepository;
            this.mapper = mapper;
        }
        public CitiesDTO AddCity(CitiesDTO addressDTO)
        {////לבדוק
            string pattern = @"^\p{IsHebrew}+(\s\p{IsHebrew}+){0,2}$";
            string name = addressDTO.CityName;
            bool isMatch = Regex.IsMatch(name, pattern);
            if (isMatch && !char.IsWhiteSpace(name[0]) && name.Split(' ').Length <= 3)
            {
                return mapper.Map<CitiesDTO>
                (citiesRepository.Addcity(mapper.Map<City>(addressDTO)));
            }
            return null;
        }

        public CitiesDTO GetCity(int id)
        {
            return mapper.Map<CitiesDTO>(citiesRepository.GetCity(id));
        }

        public List<CitiesDTO> GetAllCities()
        {
            return mapper.Map<List<CitiesDTO>>(citiesRepository.GetAllCities());
        }

        public int GetCityByName(string city)
        {
            return citiesRepository.GetCityByName(city);
        }
    }
}
