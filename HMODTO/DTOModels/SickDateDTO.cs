using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMODTO.DTOModels
{
    public class SickDateDTO
    {
        public int PersonId { get; set; }
        public DateTime SickDate { get; set; }
        public DateTime RecoverDate { get; set; }

    }
}
