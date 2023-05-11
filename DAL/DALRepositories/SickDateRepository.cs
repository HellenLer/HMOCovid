using DAL.DalContracts;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALRepositories
{


    public class SickDateRepository : ISickDateRepository
    {

        HMOContext context;
        public SickDateRepository(HMOContext context)
        {
            this.context = context;
        }

        public SickDate AddSickDate(SickDate sickDate)
        {
            context.Add(sickDate);
            context.SaveChanges();
            return sickDate;
        }

        public List<SickDate> GetAllSickDates()
        {
            return context.SickDates.ToList();
        }

        public SickDate GetSickDate(int id)
        {
            return context.SickDates.AsQueryable()
                 .Where(c => c.PersonId == id).FirstOrDefault();
        }
    }
}
