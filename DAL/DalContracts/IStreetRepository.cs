using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalContracts
{
    public interface IStreetRepository
    {
        public List<Street> GetAllStreets();
        public Street GetStreet(int id);

        public Street AddStreet(Street street);

        public int GetStreetByName(string street);


    }
}
