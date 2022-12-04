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
    public class DepartmentManager:IDepartmentService
    {
        private IDeparmentDal _deparmentDal;

        public DepartmentManager(IDeparmentDal deparmentDal)
        {
            _deparmentDal = deparmentDal;
        }

        public List<Department> GetList()
        {
            return _deparmentDal.GetAll();
        }

        public void Add(Department department)
        {
            _deparmentDal.Add(department);
        }
    }
}
