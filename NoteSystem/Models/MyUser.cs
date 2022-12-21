using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoteSystem.Models
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class MyUser
    {
        /// <summary>
        /// 用户表主键
        /// </summary>
        [Key]
        public Guid UserGUID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string? Sex { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string? Telephone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        public int? IsAdmin { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int? Status { get; set; }

        public MyUser()
        {

        }
    }
}
