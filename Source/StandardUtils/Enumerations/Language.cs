using System;
using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class Language : Enumeration
    {
        public static readonly Language Turkish = new Language(1, new Guid("6C2278238D3E4303A5DBA76349E3788E"), "Türkçe", "tr");
        public static readonly Language English = new Language(2, new Guid("DF7A9800411B4C89ABC4EA468F3949B4"), "English", "en");
        public static readonly Language Russian = new Language(3, new Guid("95F969BB0CDF4685AA4FD2269BEC57DD"), "русский", "ru");
        public static readonly Language Arabic = new Language(4, new Guid("4419E334CCC14CAFB6B5F69F3FCD58CB"), "العربية", "ar");
        public static readonly Language Chinese = new Language(5, new Guid("EF1990C6C5524E80A4FF464C197FEE56"), "简化字", "ch");
        public static readonly Language Spanish = new Language(6, new Guid("E7FEE6FEA90F4BAABB27C53D2EA1B7D9"), "Español", "es");
        public static readonly Language Hindi = new Language(7, new Guid("808A31BEECB940E694F659AC8961F8B7"), "हिन्दी", "hi"); 
        public static readonly Language Portuguese = new Language(8, new Guid("60D03AF2EDDD485791DC0C7AEC4F528F"), "Português", "pt");
        public static readonly Language Japanese = new Language(9, new Guid("B18A568E9A194ED2B3C7E19F22885C66"), "日本語", "jp");
        public static readonly Language Azerbaijani = new Language(10, new Guid("5FD20F70CA3E463E878A96EA2063FCCC"), "Azərbaycanca", "az");
        public static readonly Language Bulgarian = new Language(11, new Guid("CB847CF824074EB9A8F429A966518C99"), "Български", "bg");
        public static readonly Language Korean = new Language(12, new Guid("5CE5AB5B928149E28DC5801CE1F7B920"), "한국어", "ko");
        public static readonly Language Belarusian = new Language(13, new Guid("C7E313B9B1F84CA185E654C71DE07FE0"), "Беларуская (Акадэмічная)", "be");
        public static readonly Language Catalan = new Language(14, new Guid("7BE1D717C165433897E166B7AC04F89F"), "Català", "ca");
        public static readonly Language Czech = new Language(15, new Guid("E3DF2FA48E2A44DEA0CE2756E95A41A5"), "Čeština", "cs");
        public static readonly Language Danish = new Language(16, new Guid("3F524C0C5CDA4E5A82EF8C33398F0D68"), "Dansk", "de");
        public static readonly Language German = new Language(17, new Guid("67ED1E95EE824A6F99145C659243391D"), "Deutsch", "de");
        public static readonly Language Estonian = new Language(18, new Guid("6587414C45984EF98CD1B91F752DF270"), "Eesti", "et");
        public static readonly Language Greek = new Language(19, new Guid("11160E35A2A946F2819020F5AE20A5FF"), "Ελληνικά", "el");
        public static readonly Language Esperanto = new Language(20, new Guid("2F6B2069BA8945938F871D3F42F93EB9"), "Esperanto", "eo");
        public static readonly Language Basque = new Language(21, new Guid("0E7DF201FFC543DEA2EAD77BF569B59C"), "Euskara", "eu");
        public static readonly Language Persian = new Language(22, new Guid("A6AD1CB1B9C447868AD4C66F6ED3E83F"), "فارسی", "fa");
        public static readonly Language French = new Language(23, new Guid("C512E5204D1D4A16B198F2D0A4BD8629"), "Français", "fr");
        public static readonly Language Galician = new Language(24, new Guid("4B63D03EE6DD45DD871AD2B2CAD13C09"), "Galego", "gl");
        public static readonly Language Armenian = new Language(25, new Guid("F247A1AB98474993908F30AF40B12EF3"), "Հայերեն", "hy");
        public static readonly Language Croatian = new Language(26, new Guid("8F9BBD88EF3B4E30A491C5CD2D9A58DA"), "Hrvatski", "hr");
        public static readonly Language Indonesian = new Language(27, new Guid("22A2F40FBABF4DFE8073DD12C3EAE72F"), "Bahasa Indonesia", "id");
        public static readonly Language Italian = new Language(28, new Guid("BC9FE0665C8E4AC39CC0D7854B5DAF68"), "Italiano", "it");
        public static readonly Language Hebrew = new Language(29, new Guid("B7C08ECFAF274B0F8771576477509D04"), "עברית", "he");
        public static readonly Language Georgian = new Language(30, new Guid("FDFE6275756F47DB95344DFA9A62ED31"), "ქართული", "ka");
        public static readonly Language Latin = new Language(31, new Guid("BF3C15DF707342FF8981013F10E27B7D"), "Latina", "la");
        public static readonly Language Lithuanian = new Language(32, new Guid("D3905F0A524643B7888E9E81C11711A5"), "Lietuvių", "lt");
        public static readonly Language Hungarian = new Language(33, new Guid("991A0B5697E64D7B9C1574361CA3BDD0"), "Magyar", "hu");
        public static readonly Language Macedonian = new Language(34, new Guid("EA7830539F244946BAD3011BADC6886C"), "Македонски", "mk");
        public static readonly Language Malay = new Language(35, new Guid("59BF3AE946C54A9187BBFC5659D25A90"), "Bahasa Melayu", "ms");
        public static readonly Language Ukrainian = new Language(36, new Guid("8F1FDDDC1A554666A29661EF13E31256"), "Українська", "uk");
        public static readonly Language Dutch = new Language(37, new Guid("1B943624911942C1B6A98B19160FEC82"), "Nederlands", "nl");
        public static readonly Language NorwegianBokmal = new Language(38, new Guid("8093582A8C0846D7AC11934BD3D2ED7C"), "Norsk (Bokmål)", "no");
        public static readonly Language NorwegianNynorsk = new Language(39,new Guid("45DFC655992845FDBA3133972A374C7D"), "Norsk (Nynorsk)", "nn");
        public static readonly Language Chechen = new Language(40, new Guid("60560C00917944EC9289BF5953B8AA56"), "Нохчийн", "ce");
        public static readonly Language Uzbek = new Language(41, new Guid("7B674C160C1B46B1BC9E51FEA2E1C064"), "Oʻzbekcha / Ўзбекча", "uz");
        public static readonly Language Polish = new Language(42, new Guid("181F8838EA7841D3BA03277C4DA048D0"), "Polski", "pl");
        public static readonly Language Kazakh = new Language(43, new Guid("71ADBC11FCBD4847BE8A9CB372991F07"), "Қазақша / Qazaqşa / قازاقشا", "kk");
        public static readonly Language Romanian = new Language(44, new Guid("CD38CF3C926F46C2868D9CD6496F633A"), "Română", "ro");
        public static readonly Language Welsh = new Language(45, new Guid("6486F7082E3045EFA8D62AC5763F3230"), "Cymraeg", "cy");
        public static readonly Language Urdu = new Language(46, new Guid("F7812ECBA2FD4D7FAA03DB58D9DF475B"), "اردو", "ur");
        public static readonly Language Slovak = new Language(47, new Guid("A60C79A1CDEA4C3DB587C2372DBDF79E"), "Slovenčina", "sk");
        public static readonly Language Slovenian = new Language(48, new Guid("32AB93D5DAAE4C3ABC10749C5580E218"), "Slovenščina", "sl");
        public static readonly Language Serbian = new Language(49, new Guid("17E2CEEE761E4DDEA9C931E2465029C4"), "Српски / Srpski", "sr");
        public static readonly Language SerboCroatian = new Language(50, new Guid("571D1241B0E94516BB916D6D096354D5"), "Srpskohrvatski / Српскохрватски", "sh");
        public static readonly Language Finnish = new Language(51, new Guid("70A233FC513249B6BA86AB01AE9504D8"), "Suomi", "fi");
        public static readonly Language Swedish = new Language(52, new Guid("012A4E43642041C3889671C00F5EE485"), "Svenska", "sv");
        public static readonly Language Tamil = new Language(53, new Guid("000CE0E21EC84226B284E070AECD535F"), "தமிழ்", "ta");
        public static readonly Language Thai = new Language(54, new Guid("645DF485D65E4324975209941D6EFFAE"), "ภาษาไทย", "th");
        public static readonly Language Vietnamese = new Language(55, new Guid("CE1DFE95B21141DE8837B77FA7AAFF0D"), "Tiếng Việt", "vi");
        public static readonly Language Volapuk = new Language(56, new Guid("41E5DB6F8DF44D5EA5A175E23206E480"), "Volapük", "vo");

        public string Code { get; }

        public Language(int value, Guid uid, string name, string code) : base(value, uid, name)
        {
            Code = code;            
        }
    }
}