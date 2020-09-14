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
    public class CityController:Controller
    {
        CityService _cityService;
        public CityController(CityService cityService)
        {
            _cityService = cityService;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            var list=_cityService.GetCities();
            return Ok(list);
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var city = _cityService.GetCityById(Id);
            return Ok(city);
        }
        [HttpPut]
        public IActionResult Put(City city)
        {
            try
            {
                _cityService.UpdateCity(city);
                return Ok(city);
            }
            catch 
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _cityService.DeleteCity(Id);
            return Ok(Id);
        }
    }
}
