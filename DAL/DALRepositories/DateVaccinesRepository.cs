using DAL.DalContracts;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALRepositories
{
    public class DateVaccinesRepository : IDateVaccinesRepository
    {

        HMOContext context;
        public DateVaccinesRepository(HMOContext context)
        {
            this.context = context;
        }


        public DateVaccine AddDateVaccine(DateVaccine dateVaccine)
        {
                context.Add(dateVaccine);
                context.SaveChanges();
                return dateVaccine;
            
        }

       
        public List<DateVaccine> GetAllDateVaccine()
        {

            return context.DateVaccines.ToList();   
                }

        public DateVaccine GetDateVaccine(int id)
        {
            return context.DateVaccines.AsQueryable()
                 .Where(c => c.VaccinesKey == id).FirstOrDefault();
        }
    }
}
