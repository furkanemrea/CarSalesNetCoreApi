using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Models;
using CarSalesCoreApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Services
{
    public class CarService
    {
        ICarDal _carDal;
        public CarService(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCars()
        {
            var list = _carDal.GetList();
            return list;
        }

        public Car GetCarById(int Id)
        {
            var car = _carDal.Get(x => x.Id == Id);
            return car;
        }

        public Car AddCar(Car car)
        {
            _carDal.Add(car);
            return car;
        }
        public Car UpdateCar(Car car)
        {
            _carDal.Update(car);
            return car;
        }
        public List<CarModel> GetCarModelWithDetails(Car.Statuses statuses)
        {
            var list = _carDal.GetCarModelWithDetails(statuses);
            return list;
        }
        public int UpdateStatusPassive(int Id)
        {
            using (var context = new CarSalesContext())
            {
                var updatedEntity = context.Car.Find(Id);
                updatedEntity.Status = Car.Statuses.PASSIVE;
                updatedEntity.EndDate = DateTime.Now;
                context.SaveChanges();
            }
            return Id;
        }
    }
}
