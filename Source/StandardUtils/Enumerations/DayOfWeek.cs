using System;

using StandardUtils.Enumerations.Base;

namespace StandardUtils.Enumerations
{
    public class DayOfWeek : Enumeration
    {
        public static readonly DayOfWeek Monday = new DayOfWeek(1, new Guid("E5095925E195420096AD1B5A9E40AA8B"), "Monday");
        public static readonly DayOfWeek Tuesday = new DayOfWeek(2, new Guid("8670C2F95BD44E91B05F2098DC4A3513"), "Tuesday");
        public static readonly DayOfWeek Wednesday = new DayOfWeek(3, new Guid("845302EE4B2D4187BBA138DC788D5856"), "Wednesday");
        public static readonly DayOfWeek Thursday = new DayOfWeek(4, new Guid("2AB2A970076C4148867CFF757C298DFF"), "Thursday");
        public static readonly DayOfWeek Friday = new DayOfWeek(5, new Guid("634F91B31F374A3285BD5FB88FAE9CBD"), "Friday");
        public static readonly DayOfWeek Saturday = new DayOfWeek(6, new Guid("6888D9F0C5014E88AD6EB6CC050F5C18"), "Saturday");
        public static readonly DayOfWeek Sunday = new DayOfWeek(7, new Guid("3886CB8CAC074A54BA12878D7CF61A08"), "Sunday");

        public DayOfWeek(int value, Guid uid, string name) : base(value, uid, name)
        {
        }
    }
}