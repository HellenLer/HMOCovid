using DAL.DalContracts;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALRepositories
{
    public class MembersDetailsRepository : IMembersDetaisRepository
    {

        HMOContext context;
        public MembersDetailsRepository(HMOContext context)
        {
            this.context = context;
        }
        public MembersDetail AddMembersDetail(MembersDetail membersDetail)
        {
            context.Add(membersDetail);
            context.SaveChanges();
            return membersDetail;
        }

        public List<MembersDetail> GetAllMembersDetail()
        {
            return context.MembersDetails.ToList();
        }

        public MembersDetail GetMemberDetail(int id)
        {
            return context.MembersDetails.AsQueryable()
                 .Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
