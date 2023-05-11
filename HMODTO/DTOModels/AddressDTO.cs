using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMODTO.DTOModels
{
    public class AddressDTO
    {
        public int AddressKey { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }

        public int HouseNum { get; set; }
    }
}
