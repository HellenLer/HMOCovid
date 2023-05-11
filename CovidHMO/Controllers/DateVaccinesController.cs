using BLServices.BLContracts;
using BLServices.BLService;
using HMODTO.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidHMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DateVaccinesController : ControllerBase
    {
        IDateVaccinesService dateVaccinesService;
        public DateVaccinesController(IDateVaccinesService dateVaccinesService)
        {
            this.dateVaccinesService = dateVaccinesService;
        }
        [HttpGet]
        public List<DateVaccinesDTO> GetAllDateVaccines()
        {
            return dateVaccinesService.GetAllDateVaccines();

        }

        [HttpGet]
        public DateVaccinesDTO GetDateVaccines(int id)
        {
            return dateVaccinesService.GetDateVaccines(id);

        }
        [HttpPost]
        public DateVaccinesDTO AddDateVaccines(DateVaccinesDTO dateVaccinesDTO)
        {
            return dateVaccinesService.AddDateVaccines(dateVaccinesDTO);

        }
    }
}
