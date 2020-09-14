using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarSalesCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        UserService _userService;
        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                var userList = _userService.getUserList();
                return Ok(userList);
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _userService.getUserById(id);
                return Ok(user);
            }
            catch
            {

                return BadRequest();
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post(User user)
        {
            _userService.addUser(user);
            return Ok(user);

        }

        [HttpPut]
        public IActionResult Put(User user)
        {
            _userService.updateUser(user);
            return Ok(user);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _userService.deleteUser(id);
                return Ok(id);
            }
            catch
            {

                return Ok($"Id={id} is not found ");
            }

        }

        [HttpGet("UserDetails")]
        public IActionResult GetDetails()
        {
            try
            {
                var result = _userService.getUserDetails();
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
