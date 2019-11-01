using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class ApiModelType : Enumeration
    {
        public static readonly ApiModelType RestJson = new ApiModelType(1, new Guid("1C6A1EB0E3E24AC5A6ED8DFB1FD98EC3"), "RestJson");
        public static readonly ApiModelType RestXml = new ApiModelType(2, new Guid("AA0845AB29CD465CB3DD5004306BB8E6"), "RestXml");
        public static readonly ApiModelType Soap = new ApiModelType(3, new Guid("42C0BEAF176E452988B813D2C05941B9"), "Soap");

        public ApiModelType(int value, Guid uid, string name) : base(value, uid, name)
        {
        }
    }
}