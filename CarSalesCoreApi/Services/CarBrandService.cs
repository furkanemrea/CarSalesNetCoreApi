using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Services
{
    public class CarBrandService
    {
        ICarBrandDal _carBrandDal;
        public CarBrandService(ICarBrandDal carBrandDal)
        {
            _carBrandDal = carBrandDal;
        }
        public List<CarBrand> GetCarBrands()
        {
            var list = _carBrandDal.GetList();
            return list;
        }
        public CarBrand GetCarBrandById(int Id)
        {
            var carBrand = _carBrandDal.Get(x => x.Id == Id);
            return carBrand;
        }
        public CarBrand AddCardBrand(CarBrand carBrand)
        {
            _carBrandDal.Add(carBrand);
            return carBrand;
        }
        public CarBrand UpdateCarBrand(CarBrand carBrand)
        {
            _carBrandDal.Update(carBrand);
            return carBrand;
        }
        public int DeleteCarBrand(int Id)
        {
            _carBrandDal.Delete(new CarBrand { Id=Id});
            return Id;

        }

    }
}
