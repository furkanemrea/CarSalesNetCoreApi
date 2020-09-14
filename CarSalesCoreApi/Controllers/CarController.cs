using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        CarService _carService;
        public CarController(CarService carService)
        {
            _carService = carService;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            var list = _carService.GetCars();
            return Ok(list);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var car = _carService.GetCarById(Id);
            return Ok(car);
        }

        [HttpPost]
        public IActionResult Post(Car car)
        {
            _carService.AddCar(car);
            return Ok(car);
        }
        [HttpPut]
        public IActionResult Put(Car car)
        {

            _carService.UpdateCar(car);
            return Ok(car);
        }
        [HttpGet("Details/{status}")]
        public IActionResult GetCarModelWithDetails(Car.Statuses status)
        {
            var list = _carService.GetCarModelWithDetails(status);
            return Ok(list);
        }
        [HttpPatch("{Id}")]
        public IActionResult UpdateStatusPassive(int Id)
        {
            _carService.UpdateStatusPassive(Id);
            return Ok(Id);
        }
    }
}
