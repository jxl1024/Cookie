using CookieDemo.Framework;
using Microsoft.AspNetCore.Mvc;

namespace CookieDemo.Controllers
{
    [Route("api/CookieHelperTest")]
    [ApiController]
    public class CookieHelperTestController : ControllerBase
    {

        private readonly ICookieHelper _helper;

        public CookieHelperTestController(ICookieHelper helper)
        {
            _helper = helper;
        }


        /// <summary>
        /// 设置Cookie
        /// </summary>
        [HttpGet]
        [Route("SetCookie")]
        public void Get()
        {
            _helper.SetCookie("cookieHelperKey", "cookieHelperValue");
            // 设置过期时间
            _helper.SetCookie("cookieHelperExpiresKey", "cookieHelperExpitesValue",10);
        }

        /// <summary>
        /// 根据key获取Cookie的Value值
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCookie")]
        public string GetCookid()
        {
            return _helper.GetCookie("cookieHelperKey");
        }

        /// <summary>
        /// 根据key删除Cookie
        /// </summary>
        [HttpGet]
        [Route("DeleteCookie")]
        public void DeleteCookie()
        {
            _helper.DeleteCookie("cookieHelperKey");
        }
    }
}