using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetList();
        void Add(Department department);
    }
}
