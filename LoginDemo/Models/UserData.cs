using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models
{
    /// <summary>
    /// user và password
    /// </summary>
    /// CreatedBy: NTQ (13/03/2020)
    public class UserData
    {
        #region "Declare/Field"
        /// <summary>
        /// List users
        /// </summary>
        public static List<UserData> userDatas = new List<UserData>()
        {
            new UserData() {Username = "ntquoc", Password = "123"}
        };
        #endregion
        #region "Property"
        /// <summary>
        /// Tên đăng nhập
        /// </summary>
        public string Username { get; set; } 
        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string Password { get; set; }
        #endregion
        #region "Function/Method"
        /// <summary>
        /// Get dữ liệu user khi đăng nhập
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static UserData GetUser(string username)
        {
            return UserData.userDatas.Where(u => u.Username == username).FirstOrDefault();
        }
        #endregion
    }
}
