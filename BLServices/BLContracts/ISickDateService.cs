using DAL.Models;
using HMODTO.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLServices.BLContracts
{
    public interface ISickDateService
    {
        SickDateDTO GetSickDate(int id);
        List<SickDateDTO> GetAllSickDate();

        SickDateDTO AddSickDate(SickDateDTO sickDateDTO);

    }
}
