using Microsoft.AspNetCore.Mvc;
using NoteSystem.Contexts;
using NoteSystem.Models;
using NoteSystem.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace NoteSystem.Controllers
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MyUserController: Controller
    {
        /// <summary>
        /// 用户EF
        /// </summary>
        private readonly MyUserContext userContext;

        /// <summary>
        /// 注入用户EF
        /// </summary>
        /// <param name="userContext"></param>
        public MyUserController(MyUserContext userContext)
        {
            this.userContext = userContext;
        }

        /// <summary>
        /// 用户登陆
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string LoginIndex([FromBody] MyUser user)
        {
            MyUser myUser = null;
            myUser = userContext.MyUser.Where(o => o.UserName == user.UserName && o.Password == user.Password).FirstOrDefault();
            if (myUser != null) {
                return Result.Success(new MyUser()
                {
                    UserName = myUser.UserName
                });
            }
            else
            {
                return Result.Failed();
            }
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public string SignUp([FromBody] MyUser user) {
            //后端正则判断
            VerifyData expression = new VerifyData();
            // 用户名和密码
            bool falg1 = expression.AccountAndPwd(user.UserName);
            bool falg2 = expression.AccountAndPwd(user.Password);
            // 邮箱格式校验TODO


            if ((!falg1) || (!falg2))
            {
                return Result.Failed();
            }
            //md5加密密码
            user.Password = MD5StrEncryption.MD5Encrypt32(user.Password);


            MyUser newUser = new MyUser();
            newUser.UserName = user.UserName;
            newUser.Password = user.Password;
            newUser.UserGUID = Guid.NewGuid();
            newUser.Email = user.Email;
            userContext.Add(newUser);
            userContext.SaveChanges();
            return Result.Success();

        }
    }
}
