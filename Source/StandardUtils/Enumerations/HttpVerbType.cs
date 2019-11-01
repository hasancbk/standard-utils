using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class HttpVerbType : Enumeration
    {
        public static readonly HttpVerbType Get = new HttpVerbType(1, new Guid("F018CACA852B481BBE6AB217436AAFA7"), "Get");
        public static readonly HttpVerbType Post = new HttpVerbType(2, new Guid("E81F2FF4C6B34A74A22A288FD1E01373"), "Post");
        
        public HttpVerbType(int value, Guid uid, string name) : base(value, uid, name)
        {

        }
    }
}