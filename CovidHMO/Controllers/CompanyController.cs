using BLServices.BLContracts;
using HMODTO.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidHMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ICompanyService companyService;
        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet]
        public CompanyDTO GetCompany(int id)
        {
            return companyService.GetCompany(id);

        }
        [HttpGet]
        public List<CompanyDTO> GetAllCompanies()
        {
            return companyService.GetAllCompanies();

        }

        [HttpPost]
        public CompanyDTO AddCompanies([FromBody] CompanyDTO company)
        {
            return companyService.AddCompany(company);

        }
    }
}
