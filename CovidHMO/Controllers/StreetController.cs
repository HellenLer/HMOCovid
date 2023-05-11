using BLServices.BLContracts;
using BLServices.BLService;
using HMODTO.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidHMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StreetController : ControllerBase
    {
        IStreetService streetService;
        public StreetController(IStreetService streetService)
        {
            this.streetService = streetService;
        }
        [HttpGet]
        public List<StreetDTO> GetAllStreets()
        {
            return streetService.GetAllStreets();

        }

        [HttpGet]
        public StreetDTO GetStreet(int id)
        {
            return streetService.GetStreet(id);

        }
        [HttpPost]
        public StreetDTO AddStreet(StreetDTO street)
        {
            return streetService.AddStreet(street);

        }
    }
}
