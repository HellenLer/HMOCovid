using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMODTO.DTOModels
{
    public class DateVaccinesDTO
    {
        public int Vaccines_key { get; set; }
        public int PersonId { get; set; }
        public DateTime VaccinesDate { get; set;}
        public int Company { get; set; }
    }
}
