using BLServices.BLContracts;
using BLServices.BLService;
using HMODTO.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidHMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MembersDetailsController : ControllerBase
    {
        IMembersDetailsService membersDetailsService;
        public MembersDetailsController(IMembersDetailsService membersDetailsService)
        {
            this.membersDetailsService = membersDetailsService;
        }

        [HttpGet]
        public List<MembersDetailsDTO> GetAllMembersDetails()
        {
            return membersDetailsService.GetAllMembersDetails();

        }

        [HttpGet]
        public MembersDetailsDTO GetMembersDetails(int id)
        {
            return membersDetailsService.GetMembersDetails(id);

        }
        [HttpPost]
        public MembersDetailsDTO AddMembersDetails(MembersDetailsDTO membersDetails)
        {
            return membersDetailsService.AddMembersDetails(membersDetails);

        }
    }
}
