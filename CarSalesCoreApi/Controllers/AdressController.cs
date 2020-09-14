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
    public class AdressController : Controller
    {
        AdressService _adressService;
        public AdressController(AdressService adressService)
        {
            _adressService = adressService;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            var list = _adressService.GetAdress();
            return Ok(list);
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var adress = _adressService.GetAdressById(Id);
            return Ok(adress);
        }
        [HttpPost]
        public IActionResult Post(Adress adress)
        {
            _adressService.AddAdress(adress);
            return Ok(adress);
        }
        [HttpPut]
        public IActionResult Put(Adress adress)
        {
            _adressService.UpdateAdress(adress);
            return Ok(adress);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            _adressService.DeleteAdress(Id);
            return Ok(Id);
        }
    }
}
