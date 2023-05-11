using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DalContracts
{
    public interface ICompanyRepository
    {
        public List<Company> GetAllCompanies();
        public Company GetCompany(int id);

        public Company AddCompany(Company company);

    }
}
