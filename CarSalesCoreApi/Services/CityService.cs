using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Services
{
    public class CityService
    {
        ICityDal _cityDal;
        public CityService(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public List<City> GetCities()
        {
            var cities = _cityDal.GetList();
            return cities;
        }
        public City GetCityById(int Id)
        {
            var city = _cityDal.Get(x =>x.Id==Id);
            return city;
        }
        public City UpdateCity(City city)
        {
            _cityDal.Update(city);
            return city;
        }
        public int DeleteCity(int Id)
        {
            _cityDal.Delete(new City { Id = Id });
            return Id;
        }
    }
}
