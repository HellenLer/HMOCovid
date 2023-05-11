using DAL.DalContracts;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALRepositories
{
    public class CompanyRepository : ICompanyRepository
    {
        HMOContext context;
        public CompanyRepository(HMOContext context)
        {
            this.context = context;
        }

        public Company AddCompany(Company company)
        {
            context.Add(company);
            context.SaveChanges();
            return company;
        }

        public List<Company> GetAllCompanies()
        {
           return context.Companies.ToList();
        }

        public Company GetCompany(int id)
        {
            return context.Companies.FirstOrDefault(comp=> comp.CompanyKey==id);
        }
        


    }
}
