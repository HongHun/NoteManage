using System.Text.RegularExpressions;
using System;

namespace NoteSystem.Utility
{
    /// <summary>
    /// 正则表达式校验数据
    /// </summary>
    public class VerifyData
    {
        /// <summary>
        /// 判断账户和密码是否只有字母和数字，且为6到16位
        /// </summary>
        /// <returns></returns>
        public bool AccountAndPwd(string value)
        {
            Regex rg = new Regex("^[0-9a-zA-Z_]{5,32}$");
            return rg.IsMatch(value);
        }

        /// <summary>
        /// 判断是否数字
        /// </summary>
        public bool IsNumber(string value)
        {
            Regex rg = new Regex("^[0-9]");
            return rg.IsMatch(value);
        }

        /// <summary>
        /// 判断是否是手机号格式
        /// </summary>
        /// <returns></returns>
        public bool IsPhone(string value)
        {
            Regex rg = new Regex("^1[3/4/5/7/8][0 -9]{9}$");
            return rg.IsMatch(value);
        }

        /// <summary>
        /// 判断姓名格式是否正确
        /// </summary>
        /// <returns></returns>
        public bool IsName(string value)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5\uf900-\ufa2d]{2,20}$");
            return rg.IsMatch(value);
        }

        /// <summary>
        /// 生日格式校验
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsBirthday(string value)
        {
            Regex rg = new Regex("(\\d{4}|\\d{2})/((1[0-2])|(0?[1-9]))/(([12][0-9])|(3[01])|(0?[1-9]))\\s((1|0?)[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])");
            return rg.IsMatch(value);
        }

        /// <summary>
        /// 性别格式校验
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsSex(string value)
        {
            Regex rg = new Regex("^[男|女]{1}$");
            return rg.IsMatch(value);
        }



        /// <summary>
        /// 判断地址
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsAddress(string value)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5]{1,50}$");
            return rg.IsMatch(value);
        }
        /// <summary>
        /// 判断IBSN格式是否正确
        /// </summary>
        /// <returns></returns>
        public bool isIBSN(string value)
        {
            Regex rg = new Regex("^[0-9]{13}$");
            return rg.IsMatch(value);
        }
        /// <summary>
        /// 判断语言格式是否正确
        /// </summary>
        /// <returns></returns>
        public bool isLang(string value)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5]");
            return rg.IsMatch(value);
        }
        /// <summary>
        /// 判断分类号格式是否正确
        /// </summary>
        /// <returns></returns>
        public bool isTypeNumber(string value)
        {
            Regex rg = new Regex("^[0-9]{1,2}$");
            return rg.IsMatch(value);
        }
        /// <summary>
        /// 判断出版日期格式是否正确
        /// </summary>
        /// <returns></returns>
        public bool isPublishDate(DateTime value)
        {
            //DateTime dt = DateTime.Parse(value);
            //DateTime dtNow= DateTime.Now;//当前时间
            if (value > DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
