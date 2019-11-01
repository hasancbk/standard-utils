using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class HttpRequestBodyType : Enumeration
    {
        public static readonly HttpRequestBodyType FormData = new HttpRequestBodyType(1, new Guid("FF5D8F451475409CBC3A14A78963E080"), "FormData");
        public static readonly HttpRequestBodyType FormUrlEncoded = new HttpRequestBodyType(2, new Guid("19A3B99F8D134E25BBA358FDA8C3E43E"), "FormUrlEncoded");
        public static readonly HttpRequestBodyType Raw = new HttpRequestBodyType(3, new Guid("E1D538CA2424487FB9A3EFEE4961ED7D"), "Raw");
        
        public HttpRequestBodyType(int value, Guid uid, string name) : base(value, uid, name)
        {
        }
    }
}