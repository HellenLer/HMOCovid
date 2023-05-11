using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLContracts
{
    public interface IDateVaccinesService
    {
        DateVaccinesDTO GetDateVaccines(int id);
        List<DateVaccinesDTO> GetAllDateVaccines();

        DateVaccinesDTO AddDateVaccines(DateVaccinesDTO dateVaccinesDTO);

    }
}
