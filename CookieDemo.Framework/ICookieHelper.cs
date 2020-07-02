namespace CookieDemo.Framework
{
    public interface ICookieHelper
    {
        void SetCookie(string key, string value);

        void SetCookie(string key, string value, int expiresTime);

        string GetCookie(string key);

        void DeleteCookie(string key);
    }
}
