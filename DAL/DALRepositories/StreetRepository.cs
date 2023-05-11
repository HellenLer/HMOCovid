using DAL.DalContracts;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALRepositories
{
    public class StreetRepository : IStreetRepository
    {

        HMOContext context;
        public StreetRepository(HMOContext context)
        {
            this.context = context;
        }

        public Street AddStreet(Street street)
        {
            context.Add(street);
            context.SaveChanges();
            return street;
        }

        public List<Street> GetAllStreets()
        {
            return context.Streets.OrderBy(s=>s.NaneStreet).ToList();
        }

        public Street GetStreet(int id)
        {
            return context.Streets.AsQueryable()
                 .Where(c => c.StreetKey == id).FirstOrDefault();
        }

        public int GetStreetByName(string street)
        {
            return context.Streets.FirstOrDefault(s=> s.NaneStreet == street)?.StreetKey?? 0;
        }
    }
}
