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
    public class CarBrandController:Controller
    {
        CarBrandService _carBrandService;
        public CarBrandController(CarBrandService carBrandService)
        {
            _carBrandService = carBrandService;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            var list = _carBrandService.GetCarBrands();
            return Ok(list);
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var carBrand = _carBrandService.GetCarBrandById(Id);
            return Ok(carBrand);
        }
        [HttpPost]
        public IActionResult Post(CarBrand carBrand)
        {
            _carBrandService.AddCardBrand(carBrand);
            return Ok(carBrand);
        }
        [HttpPut]
        public IActionResult Put(CarBrand carBrand)
        {
            _carBrandService.UpdateCarBrand(carBrand);
            return Ok(carBrand);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                _carBrandService.DeleteCarBrand(Id);
                return Ok(Id);
            }
            catch 
            {
                return BadRequest();
            }
           
        }
    }
}
