using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLContracts
{
    public interface IMembersDetailsService
    {
        MembersDetailsDTO GetMembersDetails(int id);
        List<MembersDetailsDTO> GetAllMembersDetails();

        MembersDetailsDTO AddMembersDetails(MembersDetailsDTO membersDetailsDTO);

    }
}
