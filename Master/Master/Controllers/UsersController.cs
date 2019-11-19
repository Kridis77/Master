using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Master.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public List<User> GetUsers()
        {
            return Vault.Users;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(Guid id)
        {
            var user = Vault.Users.FirstOrDefault(person => person.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(Guid id, User input)
        {
            var user = Vault.Users.FirstOrDefault(person => person.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            user.Username = input.Username;
            if (input.Username == null)
            {
                return BadRequest("Username cannot be empty");
            }

            user.Name = input.Name;
            if (input.Name == null)
            {
                return BadRequest("Name cannot be empty");
            }

            user.Surname = input.Surname;
            if (input.Surname == null)
            {
                return BadRequest("Surname cannot be empty");
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUsers([FromBody]User user)
        {
            user.Id= Guid.NewGuid();
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                return BadRequest("Username cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(user.Surname))
            {
                return BadRequest("Surname cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(user.Password))
            {
                return BadRequest("Password cannot be empty");
            }

            if (string.IsNullOrWhiteSpace(user.Name))
            {
               return BadRequest("Name cannot be empty");
            }

            Vault.Users.Add(user);

            return Ok(user);
        }
    }
}