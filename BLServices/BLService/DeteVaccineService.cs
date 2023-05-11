using AutoMapper;
using BLServices.BLContracts;
using DAL.DalContracts;
using DAL.DALRepositories;
using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLService
{
    public class DeteVaccineService : IDateVaccinesService
    {
        IDateVaccinesRepository dateVaccinesRepository;
        IMapper mapper;
        public DeteVaccineService(IDateVaccinesRepository dateVaccinesRepository, IMapper mapper)
        {
            this.dateVaccinesRepository = dateVaccinesRepository;
            this.mapper = mapper;
        }
        public DateVaccinesDTO AddDateVaccines(DateVaccinesDTO dateVaccinesDTO)
        {
            return mapper.Map<DateVaccinesDTO>
                (dateVaccinesRepository.AddDateVaccine(mapper.Map<DateVaccine>(dateVaccinesDTO)));
        }

        public List<DateVaccinesDTO> GetAllDateVaccines()
        {
            return mapper.Map<List<DateVaccinesDTO>>(dateVaccinesRepository.GetAllDateVaccine());
        }

        public DateVaccinesDTO GetDateVaccines(int id)
        {
            return mapper.Map<DateVaccinesDTO>(dateVaccinesRepository.GetDateVaccine(id));
        }
    }
}
