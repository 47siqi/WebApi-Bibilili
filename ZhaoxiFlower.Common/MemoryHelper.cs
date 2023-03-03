using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ZhaoxiFlower.Common
{   
    //内存缓存，记忆验证码
    public class MemoryHelper
    {
        //注入服务
        private static IMemoryCache _memoryCache = null;
        static MemoryHelper()
        {
            if (_memoryCache == null)
            {
                _memoryCache = new MemoryCache(new MemoryCacheOptions());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expireMins">有效期</param>
        public static void SetMemory(string key, object value, int expireMins)
        {
            //设置对应key的返回值
            //TimeSpan:表示一个时间间隔。
            //TimeSpan.FromMinutes返回表示指定分钟数的 TimeSpan，其中对分钟数的指定精确到最接近的毫秒。
            _memoryCache.Set(key, value, TimeSpan.FromMinutes(expireMins));
        }
        public static object GetMemory(string key)
        {
            //根据指定的key找到对应的缓存的值
            return _memoryCache.Get(key);
        }
    }
}
