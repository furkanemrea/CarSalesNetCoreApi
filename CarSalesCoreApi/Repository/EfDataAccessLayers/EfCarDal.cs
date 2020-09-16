using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Repository.EfDataAccessLayers
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarSalesContext>, ICarDal
    {
        public List<CarModel> GetCarModelWithDetails(string cs)
        {
            using (CarSalesContext context = new CarSalesContext())
            {
                var result = (from c in context.Car
                              join cb in context.CarBrand
                              on c.BrandId equals cb.Id
                              join ctgry in context.Category
                              on c.CategoryId equals ctgry.Id
                              join mdl in context.Model on
                              c.ModelId equals mdl.Id
                              join user in context.Users
                              on c.CreatedBy equals user.Id
                              where c.Status == cs
                              select new CarModel
                              {
                                  Id = c.Id,
                                  BrandName = cb.Brand,
                                  CategoryName = ctgry.Name,
                                  Color = c.Color,
                                  CreatedBy = user.Name,
                                  CreatedDate = c.CreatedDate,
                                  KM = c.KM,
                                  ModelName = mdl.ModelName
                              });
                return result.ToList();

            }
        }
        public Car FindById(int Id)
        {
            using (var context = new CarSalesContext())
            {
                var result = context.Car.Find(Id);


                return result;
            }
        }


    }

    
}