using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalContracts
{
    public interface ISickDateRepository
    {
        public List<SickDate> GetAllSickDates();
        public SickDate GetSickDate(int id);
        public SickDate AddSickDate(SickDate sickDate);

    }
}
