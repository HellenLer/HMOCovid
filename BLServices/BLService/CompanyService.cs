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
    public class CompanyService : ICompanyService
    {
        ICompanyRepository companyRepository;
        IMapper mapper;
        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }
        public CompanyDTO AddCompany(CompanyDTO companyDTO)
        {
            return mapper.Map<CompanyDTO>
                (companyRepository.AddCompany(mapper.Map<Company>(companyDTO)));
        }
        
        public CompanyDTO GetCompany(int id)
        {
            return mapper.Map<CompanyDTO>(companyRepository.GetCompany(id));
        }

        public List<CompanyDTO> GetAllCompanies()
        {
            return mapper.Map<List<CompanyDTO>>(companyRepository.GetAllCompanies());
        }
    }
}
