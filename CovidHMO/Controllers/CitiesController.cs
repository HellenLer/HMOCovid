using BLServices.BLContracts;
using BLServices.BLService;
using HMODTO.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static CovidHMO.Controllers.CitiesController;

namespace CovidHMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        ICitiesService citiesService;
        public CitiesController(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }
        [HttpGet]
        public List<CitiesDTO> GetAllCities()
        {
            return citiesService.GetAllCities();

        }
        [HttpGet]
        public CitiesDTO GetCity(int id)
        {
            return citiesService.GetCity(id);

        }
        [HttpPost]
        public CitiesDTO AddCity([FromBody] CitiesDTO city)
        {
            return citiesService.AddCity(city);

        }
    }
}
