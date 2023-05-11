using DAL.DalContracts;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALRepositories
{
    public class AddressRepository : IAddressRepository
    {
        HMOContext context;
        public AddressRepository(HMOContext context)
        {
            this.context = context;
        }

        public Adress AddAdress(Adress adress)
        {
            context.Add(adress);
            context.SaveChanges();
            return adress;
        }

        public Adress GetAdress(int id)
        {
            return context.Adresses
                .Include(a => a.CityNavigation)
                .Include(b => b.StreetNavigation).FirstOrDefault(x => x.AdressKey == id);
        }

        public List<Adress> GetAllAdresses()
        {
            return context.Adresses
                .Include(a=> a.CityNavigation)
                .Include(b=> b.StreetNavigation)
                .ToList();
        }
    }
}
