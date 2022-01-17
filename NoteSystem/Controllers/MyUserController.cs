using Microsoft.AspNetCore.Mvc;
using NoteSystem.Contexts;
using NoteSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
