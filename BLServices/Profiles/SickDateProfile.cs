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
    internal class SickDateProfile:Profile
    {
        public SickDateProfile()
        {
            CreateMap<SickDate, SickDateDTO>().ReverseMap();
        }
    }
}
