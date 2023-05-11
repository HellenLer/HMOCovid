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
    public class DateVaccineProfile:Profile
    {
        public DateVaccineProfile()
        {
            CreateMap<DateVaccine, DateVaccinesDTO>().ReverseMap();
        }
    }
}
