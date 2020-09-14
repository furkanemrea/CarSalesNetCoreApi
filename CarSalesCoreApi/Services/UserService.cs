using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Models;
using CarSalesCoreApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Services
{
    public class UserService
    {
        IUserDal _userDal;
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> getUserList()
        {
            var list = _userDal.GetList();
            return list;
        }

        public User getUserById(int Id)
        {
            var list = _userDal.Get(x=>x.Id==Id);
            return list;
        }

        public User addUser(User user)
        {
            _userDal.Add(user);
            return user;
        }
        public User updateUser(User user)
        {
            _userDal.Update(user);
            return user;
        }
        public int deleteUser(int Id)
        {
            _userDal.Delete(new User { Id = Id });
            return Id;
        }

        public List<UserModel> getUserDetails()
        {
            var details = _userDal.GetUsersWithDetails();
            return details;
        }
    }
}
