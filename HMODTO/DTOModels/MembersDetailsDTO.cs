using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMODTO.DTOModels
{
    public class MembersDetailsDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public string City { get; set; }

        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int Phone { get; set; }
        
        public int MobilePhone { get; set; }
    }
}
