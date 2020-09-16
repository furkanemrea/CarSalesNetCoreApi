using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Models;
using CarSalesCoreApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;



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
            var car = _carDal.FindById(Id);
            if (car == null)
            {
               
            }

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
        public List<CarModel> GetCarModelWithDetails(string status)
        {
            var list = _carDal.GetCarModelWithDetails(status);
            return list;
        }
        public Car UpdateStatusPassive(int Id)
        {
            var car=GetCarById(Id);
            car.Status = "PASSIVE";
            car.EndDate = DateTime.Now;
            _carDal.Update(car);
            return car;
        }
    }
}
