using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UserManagementAPI.Model;
using UserManagementAPI.UserData;

namespace UserManagementAPI.Controllers
{
    
    [ApiController]

    public class UserController : ControllerBase
    {
       
        private IUserData _userData;
    

        public UserController(IUserData userData)
        {
          
            _userData = userData;

        }

        [HttpGet("/api/users")]
        public IActionResult GetUsers()
        {
            return Ok(_userData.GetUser());
        }



        [HttpPost("/api/users")]
        public ActionResult<Users> AddUser(Users user)
        {
            
            _userData.AddUser(user);
            return user;
        }

        //generate random user
        [HttpGet("/api/users/random")]        
        public IActionResult GetRandomUsers()
        {
           
            return Ok(_userData.GetRandomUser());
           
        }
    }
}
