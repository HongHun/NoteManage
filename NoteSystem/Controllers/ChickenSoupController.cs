using Microsoft.AspNetCore.Mvc;
using NoteSystem.Contexts;
using NoteSystem.Models;
using NoteSystem.Utility;
using System;
using System.Linq;

namespace NoteSystem.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ChickenSoupController : Controller
    {
        /// <summary>
        /// EF
        /// </summary>
        private readonly ChickenSoupContext chickenSoupContext;

        /// <summary>
        /// 注入EF
        /// </summary>
        /// <param name="chickenSoupContext"></param>
        public ChickenSoupController(ChickenSoupContext chickenSoupContext)
        {
            this.chickenSoupContext = chickenSoupContext;
        }

        /// <summary>
        /// 获取鸡汤
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetSoup()
        {
            ChickenSoup chickenSoup = chickenSoupContext.ChickenSoup.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            return Result.Success(new ChickenSoup()
            {
                Name = chickenSoup.Name
            });
        }

    }
}
