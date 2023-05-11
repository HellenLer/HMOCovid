using AutoMapper;
using BLServices.BLContracts;
using DAL.DalContracts;
using DAL.DALRepositories;
using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLService
{
    public class StreetService:IStreetService
    {
        IStreetRepository streetRepository;

        IMapper mapper;
        public StreetService(IStreetRepository streetRepository, IMapper mapper)
        {
            this.streetRepository = streetRepository;
            this.mapper = mapper;
        }

        public StreetDTO AddStreet(StreetDTO streetDTO)
        {
            return mapper.Map<StreetDTO>
                                 (streetRepository.AddStreet(mapper.Map<Street>(streetDTO)));
        }

        public List<StreetDTO> GetAllStreets()
        {
            return mapper.Map<List<StreetDTO>>(streetRepository.GetAllStreets());
        }

        public StreetDTO GetStreet(int id)
        {
            return mapper.Map<StreetDTO>(streetRepository.GetStreet(id));
        }

        public int GetStreetByName(string street)
        {
            return streetRepository.GetStreetByName(street);
        }
    }
}
