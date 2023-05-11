using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLContracts
{
    public interface IStreetService
    {
        StreetDTO GetStreet(int id);
        List<StreetDTO> GetAllStreets();

        StreetDTO AddStreet(StreetDTO streetDTO);
        int GetStreetByName(string street);

    }
}
