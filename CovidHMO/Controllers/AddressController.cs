using BLServices.BLContracts;
using BLServices.BLService;
using HMODTO.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidHMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        IAddressService addressService;
        public AddressController(IAddressService addressService)
        {
            this.addressService = addressService;
        }
        [HttpGet]
        public List<AddressDTO> GetAllAddress()
        {
            return addressService.GetAllAddress();

        }
        [HttpGet]
        public AddressDTO GetAddress(int id)
        {
            return addressService.GetAddress(id);

        }
        [HttpPost]

        public AddressDTO AddAddress([FromBody] AddressDTO address)
        {
            return addressService.AddAddress(address);

        }
    }
}
