using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Repository
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarModel> GetCarModelWithDetails(Car.Statuses statuses);
    }
}
