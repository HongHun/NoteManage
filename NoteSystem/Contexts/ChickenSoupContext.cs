using Microsoft.EntityFrameworkCore;
using NoteSystem.Models;

namespace NoteSystem.Contexts
{
    /// <summary>
    /// 
    /// </summary>
    public class ChickenSoupContext : DbContext
    {
        /// <summary>
        /// 用户EF
        /// </summary>
        public DbSet<ChickenSoup> ChickenSoup { get; set; }

        /// <summary>
        /// 自动注入连接字符串
        /// </summary>
        /// <param name="options"></param>
        public ChickenSoupContext(DbContextOptions<MyUserContext> options) : base(options)
        {

        }
    }
}
