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
    public class CategoryController : Controller
    {
        CategoryService _categoryService;
        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            var result = _categoryService.GetCategories();
            return Ok(result);
            
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            try
            {
                var category = _categoryService.GetCategoryById(Id);
                return Ok(category);
            }
            catch 
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Put(Category category)
        {
            _categoryService.UpdateCategory(category);
            return Ok(category);
        }
        [HttpPost]
        public IActionResult Post(Category category)
        {
            _categoryService.AddCategory(category);
            return Ok(category);
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int Id)
        {
            _categoryService.DeleteCategory(Id);
            return Ok(Id);
        }
    }
}
