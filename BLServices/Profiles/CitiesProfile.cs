using AutoMapper;
using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.Profiles
{
    public class CitiesProfile: Profile
    {
        public CitiesProfile()
        {
            CreateMap<City, CitiesDTO>()
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.City1))
                .ReverseMap();
        }
    }
}
