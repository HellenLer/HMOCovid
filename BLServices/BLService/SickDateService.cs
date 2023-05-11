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
    public class SickDateService:ISickDateService
    {
        ISickDateRepository sickDateRepository;

        IMapper mapper;
        public SickDateService(ISickDateRepository sickDateRepository, IMapper mapper)
        {
            this.sickDateRepository = sickDateRepository;
            this.mapper = mapper;
        }

        public SickDateDTO AddSickDate(SickDateDTO sickDateDTO)
        {
            return mapper.Map<SickDateDTO>
                                 (sickDateRepository.AddSickDate(mapper.Map<SickDate>(sickDateDTO)));
        }

        public List<SickDateDTO> GetAllSickDate()
        {
            return mapper.Map<List<SickDateDTO>>(sickDateRepository.GetAllSickDates());
        }

        public SickDateDTO GetSickDate(int id)
        {
            return mapper.Map<SickDateDTO>(sickDateRepository.GetSickDate(id));
        }
    }
}
