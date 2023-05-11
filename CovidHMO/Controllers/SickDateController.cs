using BLServices.BLContracts;
using BLServices.BLService;
using HMODTO.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidHMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SickDateController : ControllerBase
    {
        ISickDateService sickDateService;
        public SickDateController(ISickDateService sickDateService)
        {
            this.sickDateService = sickDateService;
        }

        [HttpGet]
        public List<SickDateDTO> GetAllSickDate()
        {
            return sickDateService.GetAllSickDate();

        }

        [HttpGet]
        public SickDateDTO GetSickDate(int id)
        {
            return sickDateService.GetSickDate(id);

        }
        [HttpPost]
        public SickDateDTO AddSickDate(SickDateDTO sickDateDTO)
        {
            return sickDateService.AddSickDate(sickDateDTO);

        }
    }
}
