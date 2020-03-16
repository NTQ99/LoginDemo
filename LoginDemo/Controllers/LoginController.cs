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
        List<UserData> userDatas = UserData.userDatas;
        // GET: api/Login
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// Login, check thông tin login
        /// </summary>
        /// <param name="username"></param>
        /// <returns> username của người dùng </returns>
        /// CreatedBy: NTQ (16/03/2020)
        // GET: api/Login/ntquoc
        [HttpGet("{username}", Name = "Get")]
        public string Get(string username)
        {
            return username;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Login
        [HttpPost]
        public bool Post([FromBody] UserData user)
        {
            if (user.Username == userDatas[0].Username && user.Password == userDatas[0].Password) return true;
            return false;
        }

        // PUT: api/Login/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
