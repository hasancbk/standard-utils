using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class ValidationType : Enumeration
    {
        public static readonly ValidationType Error = new ValidationType(1, new Guid("42DE555EF2BB425992EDBB834A54B728"), "Error");
        public static readonly ValidationType Warning = new ValidationType(2, new Guid("CA5BC064DD35420DBF3AA1381A4BB70B"), "Warning");
        public static readonly ValidationType Information = new ValidationType(3, new Guid("AFF01D1906FD40AFBD949D574DD13B71"), "Information");
        
        public ValidationType(int value, Guid uid, string name) : base(value, uid, name)
        {
        }
    }
}