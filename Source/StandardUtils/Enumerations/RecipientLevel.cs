using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class RecipientLevel : Enumeration
    {
        public static readonly RecipientLevel To = new RecipientLevel(1, new Guid("13267DD4EF75407383A39A7D5C169299"), "To");
        public static readonly RecipientLevel CC = new RecipientLevel(2, new Guid("A9D8CE9943AC4B628B87F35BD2673FA5"), "CC");
        public static readonly RecipientLevel BCC = new RecipientLevel(3, new Guid("F4904FFBE9D04DA995821D5B78A314CD"), "BCC");
        
        public RecipientLevel(int value, Guid uid, string name) : base(value, uid, name)
        {
        }
    }
}