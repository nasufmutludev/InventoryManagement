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
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetList()
        {
            return _userDal.GetAll();
        }

        public void Add(string username, string name, string surname, int departmentId)
        {
            var userAdd = new User()
            {
                UserName = username,
                Name = name,
                Surname = surname,
                DepartmentId = departmentId,
                Status = true
            };
            _userDal.Add(userAdd);
        }
    }
}
