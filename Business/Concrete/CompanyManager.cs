using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class CompanyManager:ICompanyService
    {
        private ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public List<Company> GetList()
        {
            return _companyDal.GetAll();
        }

        public void Add(string companyName)
        {
            var companyNameAdd = new Company()
            {
                CompanyName = companyName,
                Status = true
            };
            _companyDal.Add(companyNameAdd);
        }
    }
}
