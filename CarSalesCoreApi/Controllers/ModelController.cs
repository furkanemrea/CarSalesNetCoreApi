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
    public class ModelController:Controller
    {
        ModelService _modelService;
        public ModelController(ModelService modelService)
        {
            _modelService = modelService;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            var list= _modelService.GetModels();
            return Ok(list);
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var model = _modelService.GetModelById(Id);
            return Ok(model);
        }
        [HttpPost]
        public IActionResult Post(Model model)
        {
            _modelService.AddModel(model);
            return Ok(model);
        }

        [HttpPut]
        public IActionResult Put(Model model)
        {
            _modelService.UpdateModel(model);
            return Ok(model);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            _modelService.DeleteModel(Id);
            return Ok(Id);
        }
    }
}
