using AutoMapper;
using BLServices.BLContracts;
using DAL.DalContracts;
using DAL.DALRepositories;
using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLServices.BLService
{
    public class AddressService : IAddressService
    {
        IAddressRepository addressRepository;
        ICitiesRepository cityRepository;
        IStreetRepository streetRepository;
        IMapper mapper;
        public AddressService(IAddressRepository addressRepository,
            ICitiesRepository cityRepository,
            IStreetRepository streetRepository,
            IMapper mapper)
        {
            this.addressRepository = addressRepository; 
            this.cityRepository = cityRepository;
            this.streetRepository = streetRepository;
            this.mapper = mapper; 
        }
        public AddressDTO AddAddress(AddressDTO addressDTO)
        {
            //להוסיף בדיקות תקינות
            Adress address = mapper.Map<Adress>(addressDTO);
            KeyValuePair<int, int> ids = GetAddresstByNames(addressDTO.CityName, addressDTO.StreetName);
            address.City = ids.Key;
            address.Street = ids.Value;
            return mapper.Map<AddressDTO>
                (addressRepository.AddAdress(address));
        }

        public AddressDTO GetAddress(int id)
        {
            return mapper.Map<AddressDTO>(addressRepository.GetAdress(id));
        }

        public KeyValuePair<int, int> GetAddresstByNames(string city, string street)
        {
            int cityId = cityRepository.GetCityByName(city);
            int streetId = streetRepository.GetStreetByName(street);
            return new KeyValuePair<int, int>(cityId, streetId);
        }

        public List<AddressDTO> GetAllAddress()
        {
            return mapper.Map<List<AddressDTO>>(addressRepository.GetAllAdresses());
        }
    }
}
