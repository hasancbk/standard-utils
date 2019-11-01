using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class CurrencyType : Enumeration
    {
        public static readonly CurrencyType TRY = new CurrencyType(1, new Guid("F238552DE9C64E96A99E68BE4D1270D2"), "₺", "TRY");
        public static readonly CurrencyType USD = new CurrencyType(2, new Guid("3CF614B3E5D04E5DA019F35F5709C3B6"), "$", "USD");
        public static readonly CurrencyType EUR = new CurrencyType(3, new Guid("79C6728674644CB0B6ACF98176D369DF"), "€", "EUR");
        public static readonly CurrencyType JPY = new CurrencyType(4, new Guid("ACCFE0C297654E75ACA2070A76EFEDD0"), "¥ (jpy)", "JPY");
        public static readonly CurrencyType CNY = new CurrencyType(5, new Guid("B3925B69FE464B94A4A7FC3C4FAF11C4"), "¥ (cny)", "CNY");
        public static readonly CurrencyType GBP = new CurrencyType(6, new Guid("5E7B129133E24FBEBEA01C500720B963"), "£", "GBP");

        public string Key { get; }

        public CurrencyType(int value, Guid uid, string name, string key) : base(value, uid, name)
        {
            Key = key;
        }
    }
}