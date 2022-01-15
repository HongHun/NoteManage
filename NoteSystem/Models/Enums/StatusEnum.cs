using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteSystem.Models.Enums
{
    /// <summary>
    /// 请求状态
    /// </summary>
    public enum StatusEnum
    {
        /// <summary>
        /// 请求成功
        /// </summary>
        Success = 200,
        /// <summary>
        /// 请求失败
        /// </summary>
        Failed = 500,
        /*        /// <summary>
                /// 未授权
                /// </summary>
                Unauthorized = 401,*/
    }
}
