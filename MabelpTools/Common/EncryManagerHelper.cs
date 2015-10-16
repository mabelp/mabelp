using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MabelpTools.Common
{
    public class EncryManager
    {
        /// <summary>
        /// 默认过期缓存分钟数
        /// </summary>
        static readonly int EXPIRE_MINUTES = 10;
        /// <summary>
        /// 加密
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        //public static string EncryToString<T>(T source)
        //{
        //    string returnStr = string.Empty;
        //    string key = source.ToString();
        //    EncryProvider encryProvider = new EncryProvider();

        //    returnStr = HttpUtility.UrlEncode(encryProvider.Encrypto(key));
        //    /* Remove Cache by PuGong, 2013/9/23
        //    object strInCache = RuntimeCacheManager.Instance.GetData(key);
        //    if(strInCache==null)
        //    {
        //        returnStr = HttpUtility.UrlEncode(encryProvider.Encrypto(key));
        //        RuntimeCacheManager.Instance.Set(key, returnStr, EXPIRE_MINUTES);
        //    }else
        //    {
        //        returnStr = strInCache.ToString();
        //    }
        //    */
        //    return returnStr;
        //}

        ///// <summary>
        ///// 解密
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="source"></param>
        ///// <returns></returns>
        //public static string DecryFromString<T>(T source)
        //{
        //    string returnStr = string.Empty;
        //    string key = source.ToString();
        //    EncryProvider encryProvider = new EncryProvider();
        //    returnStr = encryProvider.Decrypto(HttpUtility.UrlDecode(key));
        //    /* Remove Cache by PuGong, 2013/9/23
        //    object strInCache = RuntimeCacheManager.Instance.GetData(HttpUtility.UrlEncode(key));
        //     if(strInCache==null)
        //    {
        //        returnStr = encryProvider.Decrypto(HttpUtility.UrlDecode(key));
        //        RuntimeCacheManager.Instance.Set(HttpUtility.UrlEncode(key), returnStr, EXPIRE_MINUTES);
        //    }else
        //    {
        //        returnStr = strInCache.ToString();
        //    }
        //     * */
        //    return returnStr;
        //}

        //#region 支付平台相关
        ///// <summary>
        ///// 创建签名
        ///// </summary>
        ///// <param name="text">明文</param>
        ///// <param name="merchantKey">商户密钥</param>
        ///// <returns>签名</returns>
        //public static string CtripPayment_CreateSign(string text, string merchantKey)
        //{
        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(text + "&Key=" + merchantKey));

        //    return BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToUpper();
        //}

        ///// <summary>
        ///// 验证签名
        ///// </summary>
        ///// <param name="text">明文</param>
        ///// <param name="merchantKey">商户密钥</param>
        ///// <param name="sign">原始签名</param>
        ///// <returns>true表示成功，false表示失败</returns>
        //public static bool CtripPayment_VerifySign(string text, string merchantKey, string sign)
        //{
        //    return CtripPayment_CreateSign(text, merchantKey).Equals(sign);
        //}
        //#endregion
    }
}
