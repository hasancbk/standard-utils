using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class CalendarType : Enumeration
    {
        public static readonly CalendarType ISO = new CalendarType(1, new Guid("C98C366A3AD94A78AAFAECE739EAE1FE"), "ISO");
        public static readonly CalendarType Gregorian = new CalendarType(2, new Guid("CA2AF8B4E53B4AC7AB3DA300DE3066F3"), "Gregorian");
        public static readonly CalendarType Coptic = new CalendarType(3, new Guid("76AB638834394F51A27C955421F39ACE"), "Coptic");
        public static readonly CalendarType Julian = new CalendarType(4, new Guid("ED9FB4F195DC49ADBC84ED4324D1065D"), "Julian");
        public static readonly CalendarType HijriCivilIndian = new CalendarType(5, new Guid("1D33A6C6E76D450EB61F161400CA46FE"), "Hijri Civil (Indian)");
        public static readonly CalendarType HijriCivilBase15 = new CalendarType(6, new Guid("6B8EFF015C6F4B1F9B75DE064CAF9AB0"), "Hijri Civil (Base15)");
        public static readonly CalendarType HijriCivilBase16 = new CalendarType(7, new Guid("789AA825EA1543F2A907079EB4D69112"), "Hijri Civil (Base16)");
        public static readonly CalendarType HijriCivilHabashAlHasib = new CalendarType(8, new Guid("898C39BCA33F40C4A56CAD44205AF5C2"), "Hijri Civil (Habash Al Hasib)");
        public static readonly CalendarType HijriAstronomicalIndian = new CalendarType(9, new Guid("6EBC247413204A76B391251F438628AD"), "Hijri Astronomical (Indian)");
        public static readonly CalendarType HijriAstronomicalBase15 = new CalendarType(10, new Guid("C4971837F2E54F839A00A3F9BEE8A708"), "Hijri Astronomical (Base15)");
        public static readonly CalendarType HijriAstronomicalBase16 = new CalendarType(11, new Guid("7588D3315E73475EABEAAEBF83339903"), "Hijri Astronomical (Base16)");
        public static readonly CalendarType HijriAstronomicalHabashAlHasib = new CalendarType(12, new Guid("3F87846C082B499DB18B567EE734ECF5"), "Hijri Astronomical (Habash Al Hasib)");
        public static readonly CalendarType PersianSimple = new CalendarType(13, new Guid("D86225241AAA4E4FA0E9D53D5D9901BB"), "Persian Simple");
        public static readonly CalendarType PersianArithmetic = new CalendarType(14, new Guid("C7CD9B5E21A34C39AEC6675D4F106DE8"), "Persian Arithmetic");
        public static readonly CalendarType PersianAstronomical = new CalendarType(15, new Guid("12B6DEECD80B4A07A3AB1000CCEC499F"), "Persian Astronomical");
        public static readonly CalendarType UmAlQura = new CalendarType(16, new Guid("F744C79AE1FA498DAC0C6EEA8D886E2E"), "Um Al Qura");
        public static readonly CalendarType HebrewCivil = new CalendarType(17, new Guid("9B398571D1364720BF1FCB615B4881E3"), "Hebrew Civil");
        public static readonly CalendarType HebrewScriptural = new CalendarType(18, new Guid("19D3C2FEBFBE40EA8CB3F8840604DBCA"), "Hebrew Scriptural");

        public CalendarType(int value, Guid uid, string name) : base(value, uid, name)
        {
        }
    }
}