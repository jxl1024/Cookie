using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookieDemo.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CookieTestController : ControllerBase
    {
        /// <summary>
        /// 设置Cookie
        /// </summary>
        [HttpGet]
        [Route("SetCookie")]
        public void Get()
        {
            HttpContext.Response.Cookies.Append("setCookie", "CookieValue");
         
            CookieOptions options = new CookieOptions();
            // 设置过期时间
            options.Expires = DateTime.Now.AddDays(1);
            HttpContext.Response.Cookies.Append("setCookieExpires", "CookieValueExpires", options);
        }

        /// <summary>
        /// 根据key获取Cookie的Value值
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCookie")]
        public string GetCookid()
        {           
            return HttpContext.Request.Cookies["setCookie"];
        }

        /// <summary>
        /// 根据key删除Cookie
        /// </summary>
        [HttpGet]
        [Route("DeleteCookie")]
        public void DeleteCookie()
        {
            HttpContext.Response.Cookies.Delete("setCookie");
        }
    }
}