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
    public class StreetProfile : Profile
    {
        public StreetProfile()
        {
            CreateMap<Street, StreetDTO>()
                .ForMember(dest => dest.StreetName, opt => opt.MapFrom(src => src.NaneStreet))
                .ReverseMap();

        }
    }
}
