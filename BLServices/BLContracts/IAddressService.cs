using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLContracts
{
    public interface IAddressService
    {
        AddressDTO GetAddress(int id);
        List<AddressDTO> GetAllAddress();
        AddressDTO AddAddress(AddressDTO addressDTO);

         KeyValuePair<int, int> GetAddresstByNames(string city, string street);

    }
}
