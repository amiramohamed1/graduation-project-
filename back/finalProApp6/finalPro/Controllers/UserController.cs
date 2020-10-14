using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using finalPro.Models;
using finalPro.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private UserRepo<User> user;
        public userController(UserRepo<User> _user)
        {
            this.user = _user;
        }
        [HttpGet]
        [Route("users")]
        public List<User> GetUsers()
        {
            return user.getAll();
        }
        [HttpGet]
        [Route("filterusers/{id}")]
        public List<User> GetUsers(int id)
        {
            return user.getallUsersFilterd(id);
        }


        [HttpGet]
        [Route("users/{id}")]
        public User GetUser(int id)
        {
            return user.getByID(id);
        }

        [HttpPost]
        [Route("users")]
        public User AddUsers(User U)
        {
            return user.Add(U);

        }
        [HttpDelete]
        [Route("users/{id}")]
        public bool deleteUsers(int id)
        {
            return user.Delete(id);

        }
 
        [HttpPut]
        [Route("users")]
        public bool updateUsers(User U)
        {
            return user.Update(U);
        }

        [HttpGet]
        [Route("log/{userName}/{password}")]
        public User GetUser(string userName,string password)
        {
            return user.Search(userName, password);
        }
    }
}