using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLContracts
{
    public interface ICompanyService
    {
         CompanyDTO GetCompany(int id);
         List<CompanyDTO> GetAllCompanies();
        CompanyDTO AddCompany(CompanyDTO companyDTO);

    }
}
