using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Repository.EfDataAccessLayers
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarSalesContext>, IUserDal
    {
        public List<UserModel> GetUsersWithDetails()
        {
            using (CarSalesContext context = new CarSalesContext())
            {
                var result = from u in context.Users
                             join a in context.Adress
                                on u.Adress equals a.Id
                             join c in context.City
                             on a.CityId equals c.Id
                             join d in context.District
                             on a.DistinctId equals d.Id
                             select new UserModel
                             {
                                 Id = u.Id,
                                 Mail=u.Mail,
                                 Adress=a.AdressName,
                                 CityName=c.CityName,
                                 DistrictName=d.DistrictName,
                                 Name=u.Name,
                                 Photo=u.Photo,
                                 Surname=u.Surname,
                                 Username=u.Username
                                
                             };
                return result.ToList();
            }
           
        }
    }
}
