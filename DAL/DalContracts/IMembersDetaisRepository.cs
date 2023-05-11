using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalContracts
{
    public interface IMembersDetaisRepository
    {
        public List<MembersDetail> GetAllMembersDetail();
        public MembersDetail GetMemberDetail(int id);
        public MembersDetail AddMembersDetail(MembersDetail membersDetail);

    }
}
