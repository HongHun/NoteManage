using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using NoteSystem.Models;

namespace NoteSystem.Contexts
{
    public class MyUserContext:DbContext
    {
        /// <summary>
        /// 用户EF
        /// </summary>
        public DbSet<MyUser> MyUser { get; set; }

        /// <summary>
        /// 自动注入连接字符串
        /// </summary>
        /// <param name="options"></param>
        public MyUserContext(DbContextOptions<MyUserContext> options) : base(options)
        {

        }
    }
}
