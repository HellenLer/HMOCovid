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
    public class AdressProfile : Profile
    {
        public AdressProfile()
        {
            CreateMap<Adress, AddressDTO>()
                .ForMember(dest => dest.AddressKey, opt => opt.MapFrom(src => src.AdressKey))
                .ForMember(dest => dest.CityName, opt => opt.MapFrom(src => src.CityNavigation.City1))
                .ForMember(dest => dest.StreetName, opt => opt.MapFrom(src => src.StreetNavigation.NaneStreet))
                .ReverseMap();
        }
    }
}
