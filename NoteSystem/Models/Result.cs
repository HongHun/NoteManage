using Newtonsoft.Json;
using NoteSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteSystem.Models
{
    /// <summary>
    /// 封装请求数据
    /// </summary>
    public class Result
    {
        /// <summary>
        /// 请求状态
        /// </summary>
        public Enum Status { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// 默认请求成功
        /// </summary>
        /// <returns></returns>
        public static string Success()
        {
            return ResultSet(StatusEnum.Success, null);
        }

        /// <summary>
        /// 请求成功并返回数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string Success(object data)
        {
            return ResultSet(StatusEnum.Success, data);
        }

        /// <summary>
        /// 请求失败
        /// </summary>
        /// <returns></returns>
        public static string Failed()
        {
            return ResultSet(StatusEnum.Failed, null);
        }
        /*
                /// <summary>
                /// 请求未授权
                /// </summary>
                /// <returns></returns>
                public static string Unauthorized()
                {
                    return ResultSet(StatusEnum.Unauthorized, null);
                }*/

        /// <summary>
        /// 请求数据封装
        /// </summary>
        /// <param name="status"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ResultSet(Enum status, object data)
        {
            Result result = new Result
            {
                Status = status,
                Data = data
            };

            return JsonConvert.SerializeObject(result);
        }
    }
}

