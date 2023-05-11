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
    public class MembersDetailsService:IMembersDetailsService
    {
        IMembersDetaisRepository membersDetaisRepository;
        IAddressService addressService; 

        IMapper mapper;
        public MembersDetailsService(IMembersDetaisRepository membersDetaisRepository,
            IAddressService addressService, 
            IMapper mapper)
        {
            this.membersDetaisRepository = membersDetaisRepository;
            this.addressService = addressService;   
            this.mapper = mapper;
        }

        public MembersDetailsDTO AddMembersDetails(MembersDetailsDTO membersDetailsDTO)
        {
            MembersDetail member = mapper.Map<MembersDetail>(membersDetailsDTO);
            KeyValuePair<int, int> ids = addressService.GetAddresstByNames
                (membersDetailsDTO.City, membersDetailsDTO.Street);
            return mapper.Map<MembersDetailsDTO>
                           (membersDetaisRepository.AddMembersDetail(mapper.Map<MembersDetail>(membersDetailsDTO)));
        }

        public List<MembersDetailsDTO> GetAllMembersDetails()
        {
            return mapper.Map<List<MembersDetailsDTO>>(membersDetaisRepository.GetAllMembersDetail());
        }

        public MembersDetailsDTO GetMembersDetails(int id)
        {
            return mapper.Map<MembersDetailsDTO>(membersDetaisRepository.GetMemberDetail(id));
        }
    }
}
