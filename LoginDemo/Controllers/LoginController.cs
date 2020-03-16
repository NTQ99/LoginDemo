using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Login, check thông tin login
        /// </summary>
        /// <param name="username"></param>
        /// <returns> username của người dùng </returns>
        /// CreatedBy: NTQ (16/03/2020)
        // GET: api/Login/ntquoc
        [HttpGet("{username}/{password}")]
        public bool Get(string username, string password)
        {
            var resUser = UserData.GetUser(username);
            if (resUser == null || resUser.Password != password) return false;
            return true;
        }
        /// <summary>
        /// register user mới
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public bool Post([FromBody] UserData user)
        {
            var resUser = UserData.GetUser(user.Username);
            if (resUser == null)
            {
                UserData.userDatas.Add(user);
                return true;
            }
            return false;
        }
    }
}
