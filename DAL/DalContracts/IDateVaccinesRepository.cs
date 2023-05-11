using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalContracts
{
    public interface IDateVaccinesRepository
    {
        public List<DateVaccine> GetAllDateVaccine();
        public DateVaccine GetDateVaccine(int id);
        public DateVaccine AddDateVaccine(DateVaccine dateVaccine);

    }
}
