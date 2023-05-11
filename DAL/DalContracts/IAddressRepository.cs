using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalContracts
{
    public interface IAddressRepository
    {
        public List<Adress> GetAllAdresses();
        public Adress GetAdress(int id);

        public Adress AddAdress(Adress adress);



    }
}
