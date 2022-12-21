using Microsoft.AspNetCore.Mvc;
using NoteSystem.Contexts;

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


    }
}
