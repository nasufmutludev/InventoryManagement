using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetList();
        void Add(string username,string name,string surname,int departmentId);
    }
}
